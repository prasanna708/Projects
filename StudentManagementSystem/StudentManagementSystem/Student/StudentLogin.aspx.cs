using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem.Student
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sid = txtStudentId.Text;
                string pwd = txtPassword.Text;
                if (sid.Trim().Length != 0 && pwd.Trim().Length != 0)
                {
                    LoginStudent(sid, pwd);
                }
                else
                    lblMessage.Text = "Please enter the above details first to login";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void LoginStudent(string sid, string pwd)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM TBLSTUDENTS WHERE RegNo = @rno AND Password = @pwd";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rno" , sid);
                cmd.Parameters.AddWithValue("@pwd" , pwd);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sid = dr["RegNo"].ToString();
                    pwd = dr["Password"].ToString();
                    Session["name"] = dr["Name"].ToString();
                    Session["rno"] = dr["RegNo"].ToString();
                    Response.Redirect("StudentHomePage.aspx");
                }
                else
                    lblMessage.Text = "Incorrect Password (or) User not found....";
                dr.Close();
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }
    }
}
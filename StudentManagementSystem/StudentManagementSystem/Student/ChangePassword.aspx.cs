using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace StudentManagementSystem.Student
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Session["name"].ToString();
                con.Open();
                string query = "SELECT * FROM TBLSTUDENTS WHERE Name = @name AND RegNo = @rno";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@rno", txtStudentId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["SecurityQuestion"] = dr["SecurityQuestion"].ToString();
                    Session["rno"] = dr["RegNo"].ToString();
                    Response.Redirect("SecurityQuestion.aspx");
                }
                else
                    lblMessage.Text = "Wrong Student ID! Please enter your Student ID...";
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
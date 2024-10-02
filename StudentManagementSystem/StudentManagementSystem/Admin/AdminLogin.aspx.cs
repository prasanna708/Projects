using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
            {
                string uid = txtUserID.Text;
                string pwd = txtPassword.Text;
                LoginAdmin(uid, pwd);
            }
            else
                lblMessage.Text = "Please enter user id and password first to login!";
        }
        private void LoginAdmin(string uid, string pwd)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString()))
                {
                    con.Open();
                    String query = "SELECT * FROM ADMINLOGIN WHERE USERID = @uid AND PASSWORD = @pwd";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    else
                    {
                        lblMessage.Text = "Invalid user id or password/user not found....!";
                    }
                }
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ECOMM_APP
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LoginUser(string tempuid, string temppwd)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM USERS WHERE UID = @uid AND PASSWORD = @pwd";
                    SqlCommand cmd = new SqlCommand(query, connection); 
                    cmd.Parameters.AddWithValue("@uid" , tempuid);
                    cmd.Parameters.AddWithValue("@pwd" , temppwd);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Session["fname"] = reader[2];
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                        lblMessage.Text = "Invalid credentials/user not found..!";
                        
                }
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (Exception ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserId.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
                {
                    string uid = txtUserId.Text;
                    string pwd = txtPassword.Text;
                    LoginUser(uid, pwd);
                }
                else
                    lblMessage.Text = "Please enter user id and password first to login!";
            }
            catch (Exception ex2)
            {
                lblMessage.Text = ex2.Message;
            }
        }
    }
}
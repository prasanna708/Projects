using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManagementSystem.Student
{
    public partial class Securityquestion : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());

        public string ques;
        public int rno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityQuestion"] != null && Session["rno"] != null)
            {
                ques = Session["SecurityQuestion"].ToString();
                rno = Convert.ToInt32(Session["rno"]);
                lblsecurityQuest.Text = ques;
            }
            Panel1.Visible = false; 
            HyperLink1.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CHANGEPASSWORD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno", rno);
                cmd.Parameters.AddWithValue("@ans", txtAnswer.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Panel1.Visible = true;
                }
                else
                    lblMessage.Text = "Wrong answer.Please enter correct answer/Try again";
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATEPASSWORD",con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno" , rno);
                cmd.Parameters.AddWithValue("@pwd" , txtPassword.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    lblMessage.Text = "Password Changed Successfully....";
                    HyperLink1.Visible = true;
                }
                else
                    lblPannelMessage.Text = "Password not changed,Please try again later";
                con.Close();
            }
            catch (SqlException ex2)
            {
                lblPannelMessage.Text = ex2.Message;
            }
        }
    }
}
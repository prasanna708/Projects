using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StudentManagementSystem.Student
{
    public partial class FeeDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            int rno = Convert.ToInt32(Session["rno"]);
            FeeAmountDetails(rno);
        }

        private void FeeAmountDetails(int rno)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_FeeDetails",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno" , rno);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblCourseFee.Text = reader[0].ToString();
                    lblFeePaid.Text = reader[1].ToString();
                    lblFeeDue.Text = reader[2].ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;  
            }
        }
    }
}
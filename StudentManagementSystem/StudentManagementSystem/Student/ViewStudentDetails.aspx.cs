using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using StudentManagementSystem.Admin;

namespace StudentManagementSystem.Student
{
    public partial class ViewStudentDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = Session["name"].ToString();
                ViewStudents(name);
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void ViewStudents(string name)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ViewStudentDeatils", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    lblStudentID.Text = dataReader["RegNo"].ToString();
                    lblName.Text = name;
                    lblGender.Text = dataReader["Gender"].ToString();
                    lblMobileNo.Text = dataReader["MobileNo"].ToString();
                    lblEmailId.Text = dataReader["EmailId"].ToString();
                    lblAddress.Text = dataReader["Address"].ToString();
                    lblPincode.Text = dataReader["Pincode"].ToString();
                    lblGraduation.Text = dataReader["Graduation"].ToString();
                    lblBranch.Text = dataReader["Branch"].ToString();
                    lblYOP.Text = dataReader["YOP"].ToString();
                    lblGrade.Text = dataReader["CGPA"].ToString();
                    lblCourse.Text = dataReader["Course"].ToString();
                    lblTotalFee.Text = dataReader["FinalFee"].ToString();
                    lblFeePaid.Text = dataReader["FeePaid"].ToString();
                }
                else
                    lblMessage.Text = "Student details not found.!";
                dataReader.Close();
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem.Admin
{
    public partial class AddNewCourse : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string CourseName = txtCourseName.Text;
                double FeeAmt = Convert.ToDouble(txtAmount.Text);
                string duration = txtDuration.Text;
                if (CourseName.Trim().Length != 0 && FeeAmt != 0 && duration.Trim().Length != 0)
                    AddCourses(CourseName, FeeAmt, duration);
                else
                    lblMessage.Text = "Plaese fill all the above fields to add a new course to courses list..!!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        private void AddCourses(string courseName, double feeAmt, string duration)
        {
            //@cname,@amt,@duration
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ADDNEWCOURSE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", courseName);
                cmd.Parameters.AddWithValue("@amt", feeAmt);
                cmd.Parameters.AddWithValue("@duration", duration);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    lblMessage.Text = courseName + " Added to courses list successfully.....";
                }
                else
                    lblMessage.Text = "Course not added! Please enter again or try later...!";
                con.Close();
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}
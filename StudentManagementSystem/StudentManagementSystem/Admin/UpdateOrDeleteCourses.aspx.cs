using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManagementSystem.Admin
{
    public partial class UpdateOrDeleteCourses : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCourses();
            }
        }

        private void LoadCourses()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLCOURSES" , con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet(); 
                da.Fill(ds , "TBLCOURSES");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                con.Close();    
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadCourses();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["CourseId"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TBLCOURSES WHERE CourseId = @cid" , con);
                cmd.Parameters.AddWithValue("@cid" , id);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "Course record deleted successfully from courses record.";
                else
                    lblMessage.Text = "Course record not deleted!Please try again later";
                con.Close();
                LoadCourses();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadCourses();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                TextBox txtCourseName = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
                TextBox txtFee = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox; 
                TextBox txtDuration = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
                int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["CourseId"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateCourses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid" , id);
                cmd.Parameters.AddWithValue("@cname" , txtCourseName.Text);
                cmd.Parameters.AddWithValue("@fee" , txtFee.Text);
                cmd.Parameters.AddWithValue("@duration" , txtDuration.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "Course Updated Successfully";
                else
                    lblMessage.Text = "Course not Updated!Please try again later...";
                con.Close();
                GridView1.EditIndex = -1;
                LoadCourses();
            }
            catch (SqlException ex2)
            {
                lblMessage.Text = ex2.Message;
            }
        }
    }
}
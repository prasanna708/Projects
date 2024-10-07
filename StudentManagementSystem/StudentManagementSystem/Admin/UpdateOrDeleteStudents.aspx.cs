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
    public partial class UpdateOrDeleteStudents : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudentDetails();
            }
        }

        private void LoadStudentDetails()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLSTUDENTS" , con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds , "TBLSTUDENTS");
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
            LoadStudentDetails();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int rno = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["RegNo"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TBLSTUDENTS WHERE RegNo = @rno" , con);
                cmd.Parameters.AddWithValue("@rno", rno);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "Student Record deleted successfully...";
                else
                    lblMessage.Text = "Student Record not deleted!Please try again later....";
                con.Close();
                LoadStudentDetails();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadStudentDetails();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int rno = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["RegNo"].ToString());
                TextBox txtName = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
                TextBox txtPassword = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
                TextBox txtGender = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
                TextBox txtCourse = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
                TextBox txtFinalFee = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
                TextBox txtFeePaid = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
                TextBox txtMobileNo = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
                TextBox txtEmailId = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;
                TextBox txtAddress = GridView1.Rows[e.RowIndex].FindControl("TextBox9") as TextBox;
                TextBox txtPincode = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
                TextBox txtGraduation = GridView1.Rows[e.RowIndex].FindControl("TextBox11") as TextBox;
                TextBox txtBranch = GridView1.Rows[e.RowIndex].FindControl("TextBox12") as TextBox;
                TextBox txtYOP = GridView1.Rows[e.RowIndex].FindControl("TextBox13") as TextBox;
                TextBox txtCGPA = GridView1.Rows[e.RowIndex].FindControl("TextBox14") as TextBox;
                TextBox txtSecQues = GridView1.Rows[e.RowIndex].FindControl("TextBox15") as TextBox;
                TextBox txtAns = GridView1.Rows[e.RowIndex].FindControl("TextBox16") as TextBox;
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateStudentRecord" , con);
                cmd.CommandType = CommandType.StoredProcedure;
                //@rno,@name,@pwd,@gender,@course,@finalfee,@feepaid,@mobileno,@email,
                //@address,@pin,@graduation,@branch,@yop,@grade,@securityquestion,@ans
                cmd.Parameters.AddWithValue("@rno" , rno);
                cmd.Parameters.AddWithValue("@name" , txtName.Text);
                cmd.Parameters.AddWithValue("@pwd" , txtPassword.Text);
                cmd.Parameters.AddWithValue("@gender" , txtGender.Text);
                cmd.Parameters.AddWithValue("@course" , txtCourse.Text);
                cmd.Parameters.AddWithValue("@finalfee" , txtFinalFee.Text);
                cmd.Parameters.AddWithValue("@feepaid" , txtFeePaid.Text);
                cmd.Parameters.AddWithValue("@mobileno" , txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@email" , txtEmailId.Text);
                cmd.Parameters.AddWithValue("@address" , txtAddress.Text);
                cmd.Parameters.AddWithValue("@pin" , txtPincode.Text);
                cmd.Parameters.AddWithValue("@graduation" , txtGraduation.Text);
                cmd.Parameters.AddWithValue("@branch" , txtBranch.Text);
                cmd.Parameters.AddWithValue("@yop" , txtYOP.Text);
                cmd.Parameters.AddWithValue("@grade" , txtCGPA.Text);
                cmd.Parameters.AddWithValue("@securityquestion" , txtSecQues.Text);
                cmd.Parameters.AddWithValue("@ans" , txtAns.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "Student Details Updates Successfully....";
                else
                    lblMessage.Text = "Student Details not updated!Please try again later...";
                con.Close();
                GridView1.EditIndex = -1;
                LoadStudentDetails();
            }
            catch (SqlException ex2)
            {
                lblMessage.Text = ex2.Message;
            }
        }
    }
}
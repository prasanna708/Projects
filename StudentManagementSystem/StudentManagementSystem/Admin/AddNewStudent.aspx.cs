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
    public partial class AddNewStudent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCourseId();

                LoadGraduation();
                string branch = DropDownListGraduation.SelectedItem.ToString();
                LoadBranches(branch);
                DropDownListQuest.Items.Insert(0,new ListItem("-----------------Select Secutiry Question-------------","0"));
            }
        }
        //Loading Graduation courses to graduation dropdownlist
        private void LoadGraduation()
        {
            DropDownListGraduation.Items.Insert(0, new ListItem("----Select Graduation----", "0"));
            DropDownListGraduation.Items.Add("BA");
            DropDownListGraduation.Items.Add("BSc");
            DropDownListGraduation.Items.Add("BCom");
            DropDownListGraduation.Items.Add("BBA");
            DropDownListGraduation.Items.Add("BTECH");
        }

        //Loading branches to brnach dropdownlist
        private void LoadBranches(string branch)
        {
            DropDownListBranch.Items.Clear();
            if (branch == "BA")
            {
                DropDownListBranch.Items.Insert(0, new ListItem("----Select Branch----", "0"));
                DropDownListBranch.Items.Add("Humanities");
                DropDownListBranch.Items.Add("Social Sciences");
                DropDownListBranch.Items.Add("Fine Arts");
                DropDownListBranch.Items.Add("Economics");
                DropDownListBranch.Items.Add("GeoGraphy");
                DropDownListBranch.Items.Add("Philosophy");
                DropDownListBranch.Items.Add("Anthropology");
            }
            else if (branch == "BSc")
            {
                DropDownListBranch.Items.Insert(0, new ListItem("--------------Select Branch--------------", "0"));
                DropDownListBranch.Items.Add("BSc in Physics");
                DropDownListBranch.Items.Add("BSc in Chemistry");
                DropDownListBranch.Items.Add("BSc in Biology");
                DropDownListBranch.Items.Add("BSc in Mathematics");
                DropDownListBranch.Items.Add("BSc in Computer Science");
                DropDownListBranch.Items.Add("BSc in Biotechnology");
                DropDownListBranch.Items.Add("BSc in Environmental Science");
            }
            else if (branch == "BCom")
            {
                DropDownListBranch.Items.Insert(0, new ListItem("------------Select Branch------------", "0"));
                DropDownListBranch.Items.Add("General Commerce");
                DropDownListBranch.Items.Add("Accounting");
                DropDownListBranch.Items.Add("Finance");
                DropDownListBranch.Items.Add("Marketing");
                DropDownListBranch.Items.Add("Business Management");
                DropDownListBranch.Items.Add("E-Commerce");
                DropDownListBranch.Items.Add("Human Resource Management");
            }
            else if (branch == "BBA")
            {
                DropDownListBranch.Items.Insert(0, new ListItem("-----------------Select Branch-----------------", "0"));
                DropDownListBranch.Items.Add("Information Technology Management");
                DropDownListBranch.Items.Add("Operations Management");
                DropDownListBranch.Items.Add("General Management");
                DropDownListBranch.Items.Add("Marketing");
                DropDownListBranch.Items.Add("Finance");
                DropDownListBranch.Items.Add("International Business");
                DropDownListBranch.Items.Add("Enterpreneurship");
            }
            else if (branch == "BTECH")
            {
                DropDownListBranch.Items.Insert(0, new ListItem("-------Select Branch-------", "0"));
                DropDownListBranch.Items.Add("CSE");
                DropDownListBranch.Items.Add("IT");
                DropDownListBranch.Items.Add("ECE");
                DropDownListBranch.Items.Add("EEE");
                DropDownListBranch.Items.Add("Mechanical Engineering");
                DropDownListBranch.Items.Add("Civil Engineering");
                DropDownListBranch.Items.Add("Chemical Engineering");
                DropDownListBranch.Items.Add("Aerospace Engineering");
            }
        }
        //Loading CourseId's to CourseId dropdownlist
        private void LoadCourseId()
        {
            DropDownListCourseID.Items.Insert(0, new ListItem("---Course ID---", "0"));
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLCOURSES", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownListCourseID.Items.Add(dr["CourseId"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = RadioButtonMale.Checked ? "Male" : RadioButtonFemale.Checked ? "Female" : null;
            //@name,@pwd,@gender,@course,@fee,@mobileno,@email,@address,@pincode,@graduation,@branch,@yop,@cgpa
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_ADDNEWSTUDENT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@course", lblCourseName.Text);
                cmd.Parameters.AddWithValue("@finalfee", lblFeeAmount.Text);
                cmd.Parameters.AddWithValue("@feePaid", txtPayment.Text);
                cmd.Parameters.AddWithValue("@mobileno", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@pincode", txtPinCode.Text);
                cmd.Parameters.AddWithValue("@graduation", DropDownListGraduation.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@branch", DropDownListBranch.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@yop", txtYOP.Text);
                cmd.Parameters.AddWithValue("@cgpa", txtCGPA.Text);
                cmd.Parameters.AddWithValue("@ques", DropDownListQuest.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@ans",txtAnswer.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "New Student Registered Successfully...";
                else
                    lblMessage.Text = "Student Registration failed! Please enter details correctly (or) Please fill out the form again...";
                con.Close();
            }
            catch (SqlException ex3)
            {
                lblMessage.Text = ex3.Message;
            }
            catch (Exception ex4)
            {
                lblMessage.Text = ex4.Message;
            }
        }
        protected void DropDownListGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string branch = DropDownListGraduation.SelectedItem.ToString();
            LoadBranches(branch);
        }

        protected void DropDownListCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLCOURSES WHERE COURSEID = @courseid", con);
                cmd.Parameters.AddWithValue("@courseid", DropDownListCourseID.SelectedItem.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblCourseName.Text = dr["CourseName"].ToString();
                    lblFeeAmount.Text = dr["Fee"].ToString();
                    lblDuration.Text = dr["Duration"].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException ex2)
            {
                lblMessage.Text = ex2.Message;
            }
        }
    }
}
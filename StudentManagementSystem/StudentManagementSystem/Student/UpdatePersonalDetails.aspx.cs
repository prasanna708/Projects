using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace StudentManagementSystem.Student
{
    public partial class UpdatePersonalDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel1.Visible = false;
                LoadGraduation();
                string branch = DropDownListGraduation.SelectedItem.ToString();
                LoadBranches(branch);
            }
        }

        //Loading Graduation Courses to graduation dropdownlist
        private void LoadGraduation()
        {
            DropDownListGraduation.Items.Insert(0, new ListItem("----Select Graduation----", "0"));
            DropDownListGraduation.Items.Add("BA");
            DropDownListGraduation.Items.Add("BSc");
            DropDownListGraduation.Items.Add("BCom");
            DropDownListGraduation.Items.Add("BBA");
            DropDownListGraduation.Items.Add("BTECH");
        }
        
        //Loading Graduation Branches to Branches dropdownlist
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Session["name"].ToString();
                con.Open();
                string query = "SELECT * FROM TBLSTUDENTS WHERE Name = @name AND RegNo = @rno";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@rno" , txtStudentID.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Panel1.Visible = true;
                    lblMessage.Text = string.Empty;
                    txtName.Text = dr["Name"].ToString();
                    txtMobileNo.Text = dr["MobileNo"].ToString();
                    txtEmailId.Text = dr["EmailId"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    txtPincode.Text = dr["Pincode"].ToString();
                    txtYOP.Text = dr["YOP"].ToString();
                    txtGrade.Text = dr["CGPA"].ToString();
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = RadioButtonMale.Checked ? "Male" : RadioButtonFemale.Checked ? "Female" : "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateStudentDetails" , con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno",txtStudentID.Text);
                cmd.Parameters.AddWithValue("@name" , txtName.Text);
                cmd.Parameters.AddWithValue("@gender" , gender );
                cmd.Parameters.AddWithValue("@mobileno" , txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@email" , txtEmailId.Text);
                cmd.Parameters.AddWithValue("@address" , txtAddress.Text);
                cmd.Parameters.AddWithValue("@pin" , txtPincode.Text);
                cmd.Parameters.AddWithValue("@graduation", DropDownListGraduation.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@branch" , DropDownListBranch.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@yop" , txtYOP.Text);
                cmd.Parameters.AddWithValue("@grade" , txtGrade.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    Panel1.Visible = false;
                    lblMessage.Text = "Your Personal details updated successfully....";
                }
                else
                {
                    Panel1.Visible = false;
                    lblMessage.Text = "Your Personal details updated!Please enter correct details or try again.....";
                }
                con.Close();
            }
            catch (SqlException ex2)
            {
                lblPannelMessage.Text = ex2.Message;
            }
        }

        protected void DropDownListGraduation_SelectedIndexChanged(object sender, EventArgs e)
        {
                string branch = DropDownListGraduation.SelectedItem.ToString();
                LoadBranches(branch);
        }
    }
}
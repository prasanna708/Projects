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
    public partial class Payments : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            btnClose.Visible = false;
            if (!IsPostBack)
            {
                LoadStudentId();
                LoadPaymentModes();
            }
        }
        private void LoadPaymentModes()
        {
            DropDownListModes.Items.Insert(0, new ListItem("---Payment Mode---", "0"));
            DropDownListModes.Items.Add("UPI");
            DropDownListModes.Items.Add("CASH");
            DropDownListModes.Items.Add("NEFT");
            DropDownListModes.Items.Add("IMPS");
            DropDownListModes.Items.Add("CHECK");
            DropDownListModes.Items.Add("CREDIT/DEBIT CARDS");
        }

        private void LoadStudentId()
        {
            DropDownListStudentID.Items.Insert(0, new ListItem("---Student ID---", "0"));
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLSTUDENTS", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DropDownListStudentID.Items.Add(dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException ex1)
            {
                lblMessage.Text = ex1.Message;
            }
        }

        protected void btnViewHistory_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            btnClose.Visible = true;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLFEETRANSACTIONS", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "TBLFEETRANSACTIONS");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                con.Close();
            }
            catch (SqlException ex3)
            {
                lblMessage.Text = ex3.Message;
            }
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            //@rno,@feeamt,@mode
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateStudentfee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno", DropDownListStudentID.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@feeamt", txtAmount.Text);
                cmd.Parameters.AddWithValue("@mode", DropDownListModes.SelectedItem.Text);
                int res = cmd.ExecuteNonQuery();
                if (res == 0)
                    lblPayment.Text = "Payment not successful! Please try again later or try again..";
                else
                    lblPayment.Text = "Payment Successful";
                con.Close();
            }
            catch (SqlException ex2)
            {
                lblPayment.Text = ex2.Message;
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void DropDownListModes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
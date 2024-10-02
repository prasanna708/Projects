using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ECOMM_APP
{
    public partial class HomePage : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());
        private string pname;
        private int price;
        private int qty;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Assigning user id to label
            if (Session["fname"] != null)
            {
                lblUserName.Text = Session["fname"].ToString();
            }
            else
                lblUserName.Text = "USERNAME";

            //Increasing count of the quantity
            if (!IsPostBack)
            { 
                Session["qty"] = 0;
                Session["qty1"] = 0;
                Session["qty2"] = 0;
                Session["qty3"] = 0;
                Session["qty4"] = 0;
                Session["qty5"] = 0;
            }
                

        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }

        //Adding Products to database
        private void AddProducts(string tpname, int tprice, int tqty)
        {
            connection.Open();
            string query1 = "INSERT INTO PRODUCTS(PNAME,PRICE,QTY) VALUES (@pname,@price,@qty)";
            SqlCommand cmd = new SqlCommand(query1, connection);
            cmd.Parameters.AddWithValue("@pname", tpname);
            cmd.Parameters.AddWithValue("@price", tprice);
            cmd.Parameters.AddWithValue("@qty", tqty);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //updating products in database
        private void UpdateProducts(string tpname, int tqty)
        {
            connection.Open();
            string query = "UPDATE PRODUCTS SET QTY=@qty WHERE PNAME=@pname";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@qty", tqty);
            cmd.Parameters.AddWithValue("@pname", tpname);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //Adding Iphone 15 to products
        protected void btnAdd1_Click(object sender, EventArgs e)
        {
            pname = "IPHONE 15";
            price = 65499;
            qty = (int)Session["qty"];
            qty++;
            Session["qty"] = qty;
            
            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblIphone15.Text = pname + " Added Successfully...";
            }
            if (qty > 1 )
            {
                UpdateProducts(pname, qty);
                lblIphone15.Text = pname + " added successfully. Quantity : " + qty;
            }
        }

        //Adding Samsung S24 Ultra to Products
        protected void btnSamsung_Click(object sender, EventArgs e)
        {
            pname = "Samsung S24 Ultra";
            price = 129999;
            qty = (int)Session["qty1"];
            qty++;
            Session["qty1"] = qty;

            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblSamsungS24.Text =  pname + " added Successfully...";
            }
            if (qty > 1)
            {
                UpdateProducts(pname, qty);
                lblSamsungS24.Text = pname + " added successfully. Quantity : " + qty;
            }
        }

        //Adding OnePlus 12 to Products 
        protected void btnOnePlus12_Click(object sender, EventArgs e)
        {
            pname = "OnePlus 12 5G";
            price = 60881;
            qty = (int)Session["qty2"];
            qty++;
            Session["qty2"] = qty;

            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblOnePlus12.Text = pname + " added Successfully...";
            }
            if (qty > 1)
            {
                UpdateProducts(pname, qty);
                lblOnePlus12.Text = pname + " added successfully. Quantity : " + qty;
            }
        }

        //Adding Iqoo Neo 9 Pro to Products
        protected void btnIqooNeo9Pro_Click(object sender, EventArgs e)
        {
            pname = "IQOO Neo 9 Pro 5G";
            price = 38999;
            qty = (int)Session["qty3"];
            qty++;
            Session["qty3"] = qty;

            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblIqoo.Text = pname + " added Successfully...";
            }
            if (qty > 1)
            {
                UpdateProducts(pname, qty);
                lblIqoo.Text = pname + " added successfully. Quantity : " + qty;
            }
        }

        //Adding Google Pixel 9 to Products
        protected void btnGooglePixel9_Click(object sender, EventArgs e)
        {
            pname = "Google Pixel 9";
            price = 79999;
            qty = (int)Session["qty4"];
            qty++;
            Session["qty4"] = qty;

            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblGooglePixel9.Text = pname + " added Successfully...";
            }
            if (qty > 1)
            {
                UpdateProducts(pname, qty);
                lblGooglePixel9.Text = pname + " added successfully. Quantity : " + qty;
            }
        }

        //Adding Samsung Z Fold 6 to products
        protected void btnSamsungZFold6_Click(object sender, EventArgs e)
        {
            pname = "Samsung Z Fold 6";
            price = 176999;
            qty = (int)Session["qty5"];
            qty++;
            Session["qty5"] = qty;

            if (qty == 1)
            {
                AddProducts(pname, price, qty);
                lblSamsungZFold6.Text = pname + " added Successfully...";
            }
            if (qty > 1)
            {
                UpdateProducts(pname, qty);
                lblSamsungZFold6.Text = pname + " added successfully. Quantity : " + qty;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ImagesDataToDBTable
{
    public partial class ImagesData : System.Web.UI.Page
    {
        //Establishing Conection to Sql Server
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IamgeConnection"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Visible = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ImageFileUpload.HasFile)
            {
                try
                {
                    byte[] ImageData;
                    //Creating a file stream object to open the image file that is uploaded 
                    using (Stream fs = ImageFileUpload.PostedFile.InputStream)
                    {
                        //creating a binary reader object to read binary data of image
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            ImageData = br.ReadBytes(Convert.ToInt32(fs.Length));
                        }
                        string ImageName = Path.GetFileName(ImageFileUpload.FileName);
                        AddIamges(ImageName , ImageData);
                        lblMessage.Text = "Image Added Successfully.";

                        //Displaying the uploaded image
                        string Base64String = Convert.ToBase64String(ImageData , 0 , ImageData.Length);  //Converting byte array to base64string
                        //Creating a data url for the image
                        Image1.ImageUrl = "data:image/jpg;base64," + Base64String;
                        Image1.Visible = true;
                    }
                }
                catch (Exception ex1)
                {
                    lblMessage.Text = ex1.Message;
                }
            }
            else
                lblMessage.Text = "Image not uploaded! Please upload an image first";
        }

        public void AddIamges(string imgname,byte[] imgdata)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO IMAGES(IMGNAME,IMGDATA) VALUES (@imgname,@imgdata)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@imgname", imgname);
                cmd.Parameters.AddWithValue("@imgdata", imgdata);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    lblMessage.Text = "Image added to database successfully...";
                else
                    lblMessage.Text = "Image not added to database!";
                connection.Close();
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}
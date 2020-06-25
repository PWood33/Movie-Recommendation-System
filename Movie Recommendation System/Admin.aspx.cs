using SQLDBConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Movie_Recommendation_System
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnAddMovie_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=sql-server;Initial Catalog=pw3649f;User ID=pw3649f;Password=!1SQLServer");
            if (imageUpload.HasFile)
            {
                string filename = imageUpload.PostedFile.FileName;
                string filepath = "Images/" + imageUpload.FileName;
                imageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/") + filename);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into [movies] values('" + DropDownList1.SelectedItem.Text +"','" + DropDownList2.SelectedItem.Text +"','" + txtMovie.Text +"', '" + txtMovdes.Text + "', '" + filepath + "', '" + txtmovtags.Text + "' )", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Movies have been added');</script>");


            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Recommendation_System
{
    public partial class AllMovies : System.Web.UI.Page
    {
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {   
                refreshdata();

            }
        }
        public void refreshdata()
        {
            SqlConnection con = new SqlConnection("Data Source=sql-server;Initial Catalog=pw3649f;User ID=pw3649f;Password=!1SQLServer");
            SqlCommand cmd = new SqlCommand("SELECT [MovieTitle],[MovieImage],[MovieID] FROM movies", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }


        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[4].Visible = false;
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "MovieTitle")
            {
                Response.Redirect("ViewDetails.aspx?id=" + e.CommandArgument.ToString());
            }

         }

  
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["pw3649fConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            con.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "SELECT * from [movies] where MovieTitle like '%'+@MovieTitle+'%'"; 
            //='" + DropDownList1.SelectedItem.Text + "'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = con;
            sqlcomm.Parameters.AddWithValue("MovieTitle", txtsearch1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            GridView1.DataSource = dt;;
            GridView1.DataBind();
        }
    }

}

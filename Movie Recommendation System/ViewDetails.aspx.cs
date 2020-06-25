using SQLDBConnect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Movie_Recommendation_System
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();

        public object TextBox1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "download")
            {
                Response.Redirect("DownloadPage.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DatabaseConnection storeData = new DatabaseConnection();
            storeData.DBExecution("INSERT INTO [movies] ([MovieRatings]) VALUES ('" + TextBox1 + "')");

            if (storeData.dbTable.Rows.Count == 0)
            {
                Response.Redirect("~/AllMovies.aspx");
            }
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Recommendation_System
{
    public partial class TopGenres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("GenreID"), new DataColumn("GenreName"), new DataColumn("Movies in Genre")});
                dt.Rows.Add(7, "Action", "Avengers Endgame");
                dt.Rows.Add(2, "Horror", "Get Out");
                dt.Rows.Add(1, "Comedy", "Hangover");
                dt.Rows.Add(4, "Romance", "Love Actually");
                GridViewRec1.DataSource = dt;
                GridViewRec1.DataBind();
            }
        }
    }
}
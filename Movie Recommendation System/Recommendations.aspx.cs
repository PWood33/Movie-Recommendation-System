using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Recommendation_System
{
    public partial class Recommendations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            

        //        public PearsonCorrelation pcCalculator = new PearsonCorrelation();
        //// For the coeffieffient score
        //public double = pcCalculator.FromOnlineGetPearsonCorrelation(pcCalculator.testData.pref);

        //// For matches
        //public Dictionary sorted = pcCalculator.TopMatches(preferences, entity, limit, pcCalculator.FromOnlineGetPearsonCorrelation(PearsonCorrelation.testData.pref));


        ////DataTable dt = new DataTable();
        //dt.Columns.AddRange(new DataColumn[2] { new DataColumn("MovieRatings"), new DataColumn("MovieTitle") });
        //dt.Rows.Add(2, "IT");
        //dt.Rows.Add(3, "Avengers EndGame");
        //dt.Rows.Add(10, "Ant-man");
        //dt.Rows.Add(11, "Hangover");
        //dt.Rows.Add(12, "Inbetweeners");
        GridViewRec.DataSource = dt;
                GridViewRec.DataBind();
            }
        }


        protected void GridViewRec_RowDataBound(object sender, GridViewRowEventArgs e)
{ }  
    

    protected void GridViewRec_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "MovieTitle")
            {
                Response.Redirect("ViewDetails.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        protected void GridViewRec_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
        }
    }
}
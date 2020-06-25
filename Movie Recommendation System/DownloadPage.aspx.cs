using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Recommendation_System
{
    public partial class DownloadPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("MovieID");
                dt.Columns.Add("MovieTitle");


                if (Request.QueryString["ID"] != null)
                {
                    if (Session["download"] == null)
                    {

                        dr = dt.NewRow();
                        String mycon = "Data Source = sql - server; Initial Catalog = pw3649f; User ID = pw3649f; Password = !1SQLServer";
                        SqlConnection scon = new SqlConnection(mycon);
                        String myquery = "select * from movies where MovieID=" + Request.QueryString["ID"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["MovieID"] = ds.Tables[0].Rows[0]["MovieID"].ToString();
                        dr["MovieTitle"] = ds.Tables[0].Rows[0]["MovieTitle"].ToString();
                        dt.Rows.Add(dr);
                        dgvDownload.DataSource = dt;
                        dgvDownload.DataBind();
                        Session["download"] = dt;
                    }
                    else
                    {

                        dt = (DataTable)Session["download"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        String mycon = "Data Source = sql - server; Initial Catalog = pw3649f; User ID = pw3649f; Password = !1SQLServer";
                        SqlConnection scon = new SqlConnection(mycon);
                        String myquery = "select * from movies where MovieID =" + Request.QueryString["ID"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["MovieID"] = ds.Tables[0].Rows[0]["MovieID"].ToString();
                        dr["MovieTitle"] = ds.Tables[0].Rows[0]["MovieTitle"].ToString();
                        dt.Rows.Add(dr);
                        dgvDownload.DataSource = dt;
                        dgvDownload.DataBind();
                        Session["download"] = dt;
                    }
                }
                else
                {
                    dt = (DataTable)Session["download"];
                    dgvDownload.DataSource = dt;
                    dgvDownload.DataBind();

                }

            }
            }
    }
}
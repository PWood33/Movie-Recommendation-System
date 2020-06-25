using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_Recommendation_System
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (MenuItem item in Menu1.Items)
            {
                Observe(item);
            }
        }

        private void Observe(MenuItem item)
        {
            if (item.NavigateUrl.Equals(Request.AppRelativeCurrentExecutionFilePath, StringComparison.InvariantCultureIgnoreCase))
            {
                item.Selected = true;
            }
            else if (item.ChildItems.Count > 0)
            {
                foreach(MenuItem menuItem in item.ChildItems)
                {
                    Observe(menuItem);
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DownloadPage.aspx");
        }
    }
}
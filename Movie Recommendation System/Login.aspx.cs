using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using SQLDBConnect;
using System.Data;
using System.Configuration;

namespace Movie_Recommendation_System
{
    public partial class Login : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void LoginButton_Click(object sender, EventArgs e)
        {

            var log = from l in db.userregisters
                      where l.Email == EmailTextBox.Text && l.Password == PasswordTextBox.Text
                      select l;

            if (log.Count() > 0)
            {
                Response.Redirect("~/MainPage.aspx");
            }
            else
            {
                LblMessage1.Text = "Incorrect Username and Password";
            }
        }


        protected void LBSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var log = from l in db.adminmanagements
                      where l.AdminEmail == EmailTextBox.Text && l.AdminPassword == PasswordTextBox.Text
                      select l;

            if (log.Count() > 0)
            {
                Response.Redirect("~/Admin.aspx");
            }
            else
            {
                LblMessage1.Text = "Incorrect Username and Password";
            }
        }
    }
    }








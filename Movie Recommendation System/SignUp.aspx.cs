using SQLDBConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Movie_Recommendation_System
{
    public partial class SignUp : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var reg = from r in db.userregisters
                              where r.Email == EmailTextBox.Text
                              select r;

                    if (reg.Count() == 0)
                    {
                        userregister user = new userregister();
                        user.FirstName = FNameTextBox.Text;
                        user.LastName = LNameTextBox.Text;
                        user.Address = AddressTextBox.Text;
                        user.Telephone = PhoneTextBox.Text;
                        user.Email = EmailTextBox.Text;
                        user.Password = PasswordTextBox.Text;

                        db.userregisters.InsertOnSubmit(user);
                        db.SubmitChanges();

                        Response.Redirect("~/Login.aspx");
                    }
                }
                catch (Exception ex)
                {
                    LblMessage.Text = ex.Message;
                }
            }
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {  
            Response.Redirect("~/Login.aspx");
        }
    }
}

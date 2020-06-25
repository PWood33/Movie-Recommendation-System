using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SQLDBConnect
{
    public class DatabaseConnection
    {
        SqlConnection db = new SqlConnection();
        public DataTable dbTable = new DataTable();

        public DatabaseConnection()
        { 
            db.ConnectionString = ConfigurationManager.ConnectionStrings["pw3649fConnectionString"].ConnectionString;

        }

        public void ObtainData(string command) // Getting the data from the db (executes Insert,Update, Delete)
        {
            try
            {
                db.Open();
                SqlDataAdapter sql = new SqlDataAdapter(command, db);
                sql.Fill(dbTable);

            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('No Connection"
                    + "DB Connecting : " + ex.Message + "');</script");

            }
            finally
            {
                db.Close();
            }
        }

        internal void DBExecution(object p)
        {
            throw new NotImplementedException();
        }

        public void DBExecution(string command) /// use this to execute function
        {
            try
            {
                db.Open();
                SqlCommand dbcommand = new SqlCommand(command, db);

                int rowChosen = dbcommand.ExecuteNonQuery();
                if (rowChosen > 0)
                {
                    HttpContext.Current.Response.Write("<script>alert('Thank You for creating an Account');</script>");
                }
                else
                    HttpContext.Current.Response.Write("<script>alert('Details not saved');</script>");
            }
          
            
                catch (Exception ex)
                {
                Console.WriteLine(ex);
                }
                finally
                {
                    db.Close();
                }
            }
        }

    }

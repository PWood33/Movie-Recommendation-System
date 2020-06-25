using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    public class PageRateCon
    {

        static string myconnstr = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        #region Count Page Rating (Insert Update Page Rating)
        public bool CountPageRate(int id, int rate)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {

                string sql = string.Format("SELECT COUNT (*) FROM  WHERE MovieID=" + id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    //Brand Do not Exist (INSERT)
                    string sql2 = string.Format("INSERT INTO movies (MovieID,MovieRatings) VALUES (" + id + "," + rate + ",1)");
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);


                    //Execute Query
                    int rows = cmd2.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        //Successfully Inserted
                        isSuccess = true;
                    }
                    else
                    {
                        //FAiled to Insert
                        isSuccess = false;
                    }
                }
                else
                {
                    //Brand Exists (Update)
                    string sql2 = string.Format("UPDATE movies SET MovieRatings=MovieRatings+" + rate + ",MovieRatings=MovieRatings+1 WHERE MovieID=" + id);
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);


                    //Execute Query
                    int rows = cmd2.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        //Successfully Inserted
                        isSuccess = true;
                    }
                    else
                    {
                        //FAiled to Insert
                        isSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step : Close COnnection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

    }
}


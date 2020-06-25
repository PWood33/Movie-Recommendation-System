using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    class GenresList
    {
    }
}

//static string con = ConfigurationManager.ConnectionStrings["pw3649fConnectionString"].ConnectionString;


//public static List<Genreclass> GetMoviesBYGenre(string category)
//{

//    SqlConnection conn = new SqlConnection(con);

    

//    List<Genreclass> list = new List<Genreclass>();
//    try
//    {

//        string sql = string.Format("SELECT * FROM movies WHERE GenreID='" + genre + "'");


//        conn.Open();


//        SqlCommand cmd = new SqlCommand(sql, conn);
//        SqlDataReader reader = cmd.ExecuteReader();


//        while (reader.Read())
//        {
//            Genreclass genre = new Genreclass
//            {
//                MovieID = Convert.ToInt32(reader["MovieID"]),
//                MovieTitle = Convert.ToString(reader["MovieTitle"]),
//                GenreID = Convert.ToInt32(reader["Genre"])
//            };
//            list.Add(genre);
//        }

//    }
//    catch (Exception ex)
//    {

//    }
//    finally
//    {
//        conn.Close();
//    }
//    return list;
//}

//    }
//}

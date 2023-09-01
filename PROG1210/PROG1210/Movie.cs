using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PROG1210
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string YearProduced { get; set; }
        public int ReviewStars { get; set; }
        public int formatID { get; set; }
        public int ratingID { get; set; }

        override public string ToString()
        {
            return Title;
        }

        //Write a static data access method in your Movie class named GetAllMovies.The method has an out parameter that
        //provides an appropriate status message and returns all the movie records as objects in a collection of type List<Movie>.
        //Use an SQL Select statement to retrieve the records.
        public static List<Movie> GetAllMovies(out string status)
        {
            List<Movie> movies = new List<Movie>();
            status = "OK";
            try
            {
                //Create a SQLCommand object to execute the SQL statement
                string sql = "SELECT * FROM Movie";
                using (SqlCommand cmd = new SqlCommand(sql, Data.con))
                {
                    //Open the connection
                    Data.con.Open();
                    //Execute the SQL statement
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //Read the data
                        while (dr.Read())
                        {
                            Movie movie = new Movie();
                            movie.ID = Convert.ToInt32(dr["ID"]);
                            movie.Title = dr["Title"].ToString();
                            movie.YearProduced = dr["YearProduced"].ToString();
                            movie.ReviewStars = Convert.ToInt32(dr["ReviewStars"]);
                            movie.formatID = Convert.ToInt32(dr["formatID"]);
                            movie.ratingID = Convert.ToInt32(dr["ratingID"]);
                            movies.Add(movie);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            finally
            {
                Data.con.Close();
            }
            return movies;
        }

        //Write a static data access method in your Movie class named GetMovie.The method receives an ID for a Movie and
        //has an out parameter that provides an appropriate status message.If the record exists the method returns it as a Movie
        //object otherwise the method returns null. Use an SQL Select statement for this method
        public static Movie GetMovie(int id, out string status)
        {
            Movie movie = null;
            status = "OK";
            try
            {
                //Create a SQLCommand object to execute the SQL statement
                string sql = "SELECT * FROM Movie WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(sql, Data.con))
                {
                    //Add the parameter
                    cmd.Parameters.AddWithValue("@ID", id);
                    //Open the connection
                    Data.con.Open();
                    //Execute the SQL statement
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //Read the data
                        if (dr.Read())
                        {
                            movie = new Movie();
                            movie.ID = Convert.ToInt32(dr["ID"]);
                            movie.Title = dr["Title"].ToString();
                            movie.YearProduced = dr["YearProduced"].ToString();
                            movie.ReviewStars = Convert.ToInt32(dr["ReviewStars"]);
                            movie.formatID = Convert.ToInt32(dr["formatID"]);
                            movie.ratingID = Convert.ToInt32(dr["ratingID"]);
                        }
                        else
                        {
                            status = "Movie not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            finally
            {
                Data.con.Close();
            }
            return movie;
        }

        //Write a static data access method in your Movie class named UpdateMovie.The method receives a Movie object to insert(if new) or update in the database.You must write code that determines which operation to perform (Insert or Update) for the object passed in. For example, you could set a private Boolean(bool) to true when the object exists in the database.For new objects, the Boolean would be set to false. The method has an out parameter that provides an appropriate status message and returns true or false depending on the success of the operation.Use SQL Insert and Update statements to perform these CRUD operations.
        public static bool UpdateMovie(Movie movie, out string status)
        {
            bool success = false;
            status = "OK";
            try
            {
                //Create a SQLCommand object to execute the SQL statement
                string sql = "";
                if (movie.ID == 0)
                {
                    //Insert
                    sql = "INSERT INTO Movie (Title, YearProduced, ReviewStars, formatID, ratingID) VALUES (@Title, @YearProduced, @ReviewStars, @formatID, @ratingID)";
                }
                else
                {
                    //Update
                    sql = "UPDATE Movie SET Title = @Title, YearProduced = @YearProduced, ReviewStars = @ReviewStars, formatID = @formatID, ratingID = @ratingID WHERE ID = @ID";
                }
                using (SqlCommand cmd = new SqlCommand(sql, Data.con))
                {
                    //Add the parameters
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@YearProduced", movie.YearProduced);
                    cmd.Parameters.AddWithValue("@ReviewStars", movie.ReviewStars);
                    cmd.Parameters.AddWithValue("@formatID", movie.formatID);
                    cmd.Parameters.AddWithValue("@ratingID", movie.ratingID);
                    if (movie.ID != 0)
                    {
                        cmd.Parameters.AddWithValue("@ID", movie.ID);
                    }
                    //Open the connection
                    Data.con.Open();
                    //Execute the SQL statement
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                    else
                    {
                        status = "No record updated";
                    }
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            finally
            {
                Data.con.Close();
            }
            return success;
        }


    }
}

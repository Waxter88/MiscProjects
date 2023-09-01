using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROG1210;

namespace PROG1210___Assignment_1_Web_App
{
    public partial class Movies : System.Web.UI.Page
    {
        List<Movie> movies;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string status;
                movies = Movie.GetAllMovies(out status);
                if (status == "OK")
                {
                    //txtTitle.Text = status;
                    foreach (Movie movie in movies)
                    {
                        //add movie to dropdown list (dropdownlist1)
                        DropDownList1.Items.Add(movie.Title);
                    }
                }
                else
                {
                    //error
                    //txtTitle.Text = status;
                }
            }
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int value = Int32.Parse(DropDownList1.SelectedItem.Value);
            Movie selectMovie = null;
            movies = Movie.GetAllMovies(out string status);
            if (status == "OK")
            {
                foreach (Movie movie in movies)
                {
                    if (movie.ID == value)
                    {
                        selectMovie = movie;
                    }
                }
            }
            else
            {
                //error
            }

            txtTitle.Text = selectMovie.Title;
            txtRating.Text = selectMovie.ReviewStars.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //The user can make changes to the Movie title (txtTitle) and rating (txtRating) and save it back to the database by calling the UpdateMovie method. Do not allow changes to the other fields including primary or foreign keys.
            string movieTitle = txtTitle.Text;
            int movieRating = Int32.Parse(txtRating.Text);
            int movieID = Int32.Parse(DropDownList1.SelectedItem.Value);
            movies = Movie.GetAllMovies(out string status);
            if (status == "OK")
            {
                foreach (Movie m in movies)
                {
                    if (m.ID == movieID)
                    {
                        m.Title = movieTitle;
                        m.ReviewStars = movieRating;
                        Movie.UpdateMovie(m, out string updateStatus);
                        txtStatus.Text = updateStatus;
                    }
                }
            }
            else
            {
                txtStatus.Text = status;
            }



        }
    }
}
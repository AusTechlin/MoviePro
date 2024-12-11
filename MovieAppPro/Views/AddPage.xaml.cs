using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppPro.Models;

namespace MovieAppPro.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
    }

    private void SaveMovie_OnClicked(object sender, EventArgs e)
    {
        var movie = new Movie();
        movie.Title = txtTitle.Text;
        movie.Rating = txtRating.Text;
        
        //App.MovieList.Add(movie);
        App.MovieList.SaveMovie(movie);
        
        txtTitle.Text = "";
        txtRating.Text = "";
    }
}
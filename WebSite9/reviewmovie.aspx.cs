using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using Newtonsoft.Json.Linq;
using System.Data;

public partial class reviewmovie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebService wb = new WebService();
        string id = (string)Session["movieId"];
        string movietitle = wb.movie_title(id);
        string movieplot = wb.movie_plot(id);
        Image1.ImageUrl = Session["url"].ToString();
        title.Text = movietitle;
        story.Text = movieplot;

    }

    protected async void Button1_Click(object sender, EventArgs e)
    {
        YoutubeMovieTrailer yt = new YoutubeMovieTrailer();
        WebService wb = new WebService();
      
        string id = Session["movieId"].ToString();
        string movietitle = wb.movie_title(id);
        await yt.Search(movietitle);
         
        string ytid = yt.output[0].Item2;
        ytplayer.Src= string.Format("https://www.youtube.com/embed/{0}", ytid);
    }
}
//watch? v
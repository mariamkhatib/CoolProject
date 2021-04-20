using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;


using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

/// <summary>
/// Summary description for YoutubeMovieTrailer
/// </summary>

public class YoutubeMovieTrailer
{//AIzaSyBI6G06VcNYIJVBO4ujPPrlAxdEW-7Ap2A
  //  AIzaSyBhlnJbAe9X06gYLfJbcz9M9M7zDyOrlZY
    private string key = "AIzaSyBhlnJbAe9X06gYLfJbcz9M9M7zDyOrlZY";
    public List<Tuple<string, string>> output { get; set; } // first string is the title ,second string is video id in youtube 

    public  YoutubeMovieTrailer()
    {
        
        //
        // TODO: Add constructor logic here
        //
    }
    public async Task Search(string title)
    {
        output = await Run(title);
    }
    public async Task<List<Tuple<string, string>>> Run(string keyword)
    {
        List<Tuple<string, string>> output = new List<Tuple<string, string>>();
        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = this.key,
            ApplicationName = this.GetType().ToString()
        });

        var searchListRequest = youtubeService.Search.List("snippet");

        searchListRequest.Q = keyword + " trailer"; // Replace with your search term.
        searchListRequest.MaxResults = 100;

        List<Tuple<string, string>> videos = new List<Tuple<string, string>>();

        var searchListResponse = await searchListRequest.ExecuteAsync();




        foreach (var searchResult in searchListResponse.Items)
        {
            if (searchResult.Id.Kind.Equals("youtube#video"))
            {
                videos.Add(new Tuple<string, string>(searchResult.Snippet.Title, searchResult.Id.VideoId));


            }
           
        }
        output = videos;

        return output;
    }
    public bool comparestring(Tuple<string,string> s)
    {
        return s.Item1.ToUpper().Contains("TRAILER");
    }
}
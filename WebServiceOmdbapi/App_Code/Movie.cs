using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Movie
/// </summary>
public class Movie
{
    public string posterurl { get;  set; }
    public string plot { get;  set; }
    public string id { get;  set; }
    public string title { get; set; }
    public string year { get;  set; }

    public Movie()
    {
        posterurl = "";
        plot = "";
        id = "";
        title = "";
        year = "";
        //
        // TODO: Add constructor logic here
        //
    }
}
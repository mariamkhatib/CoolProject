using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    
   static string apikey = "94a7afd2";
   
    [WebMethod]
    public object movie_by_method(string id, string method)
    {

        //Define your baseUrl
        string baseUrl = String.Format("http://www.omdbapi.com/?apikey={1}&{2}={0}&plot=full", id, apikey,method);
        //Have your using statements within a try/catch blokc that will catch any exceptions.
        try
        {
            //We will now define your HttpClient with your first using statement which will use a IDisposable.
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = client.GetAsync(baseUrl).Result)
                {
                    //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                    using (HttpContent content = res.Content)
                    {
                       
                        var data = content.ReadAsStringAsync();
                        data.Wait();
                        //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                        if (data != null)
                        {
                            //Now log your data object in the console
                            JObject json = JObject.Parse(data.Result);

                            return json;
                        }
                        else
                        {
                            
                            System.Diagnostics.Debug.WriteLine("json null");
                            return null;
                        }
                    }
                    
                }
            }
        }
        catch (Exception exception)
        {
            System.Diagnostics.Debug.WriteLine("Exception Hit mariam------------");
            System.Diagnostics.Debug.WriteLine(exception);
            return null;
        }
    }

    [WebMethod]
    public object movie_by_id(string id)
    {
        return movie_by_method(id, "i");
    }
   [WebMethod]
    public object movie_by_title(string title)
    {
        return movie_by_method(title, "t");
    }
    
    [WebMethod]
    public string fillpicture(string id)
    {
        JObject json = (JObject)movie_by_id(id);
        return json["Poster"].ToString();
    }
    [WebMethod]
    public string movie_title(string id)
    {
        JObject json = (JObject)movie_by_id(id);
        return json["Title"].ToString();
    }
    [WebMethod]
    public string movie_plot(string id)
    {
        JObject json = (JObject)movie_by_id(id);
        return json["Plot"].ToString();
    }
    [WebMethod]
    public string movie_genre(string id)
    {
        JObject json = (JObject)movie_by_id(id);
        return json["Genre"].ToString();
    }
    [WebMethod]
    public string movie_id(string title)
    {
        JObject json = (JObject)movie_by_title(title);
        return json["imdbID"].ToString();
    }

}

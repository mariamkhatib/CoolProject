using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using localhost;
using System.Net;
using System.IO;

using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for imgurl
/// </summary>
public class IDimage
{
    public IDimage()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string IsUrlExist(string ID,string imagefolder,string relativefolder)
    {
        string SqlStr = "select  [ID],[localposter],[imageName] from [idTbl] where [ID]='" + ID + "'";
        DataTable dt = Dbase.SelectFromTable(SqlStr, "IDmovie.mdb");
        if (dt.Rows.Count > 0 && (bool)dt.Rows[0]["localposter"])
            return Path.Combine(relativefolder,dt.Rows[0]["imageName"].ToString());
        
        else
        {
            try
            {
                WebService wb = new WebService();
                string imgurl = wb.fillpicture(ID);
                string title = wb.movie_title(ID);
                string imagename = ID + Path.GetExtension(imgurl);
                string imagepath = Path.Combine(imagefolder,imagename );
                if (!imgurl.Equals(""))
                {
                    if (!(bool)dt.Rows[0]["localposter"]) // if there is no local image
                    {
                        using (WebClient client = new WebClient())
                        {
                           
                            client.DownloadFile(new Uri(imgurl), imagepath);
                            string updatequery = "UPDATE [idTbl] SET [localposter] = TRUE,[imageName]='" + imagename + "',[movieTitle]='" + title + "' WHERE [ID] ='" + ID + "';";
                            Dbase.ChangeTable(updatequery, "IDmovie.mdb");
                            return imgurl;// we set image name to ID
                        }
                    }
                    else
                    {
                        using (WebClient client = new WebClient())
                        {
                          
                             client.DownloadFile(new Uri(imgurl), imagepath);
                            string updatequery = @"INSERT INTO [idTbl]([ID],[localposter],[imageName],[movieTitle]) VALUES('" + ID + "',TRUE,'" + imagename + "','"+title+"')";
                            Dbase.ChangeTable(updatequery, "IDmovie.mdb");
                            return imgurl;// we set image name to ID
                        }
                    }
                }
                else
                    return "";
            }
            catch (WebException ex)
            {
                // generic error handling
                System.Diagnostics.Debug.WriteLine(string.Format("Could not get data. {0}", ex));
                return "";
            }
        }
    }
    
}
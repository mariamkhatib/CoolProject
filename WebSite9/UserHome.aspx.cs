using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Data;
public partial class UserHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        var ctrl = new WebControl(HtmlTextWriterTag.Div) { CssClass = "wrapper" };

        ctrl.Attributes["style"] = "float:left;display:inline-block;margin:3px;";
        string str = "SELECT ID From idTbl;";
        string DbName = "IDmovie.mdb";
        DataTable dt = new DataTable();
        dt = Dbase.SelectFromTable(str, DbName);
        string id = "";
        int i = 1;
        localhost.WebService wb = new localhost.WebService();
        for (int j = 0; j < dt.Rows.Count; j++)
        {
            //hh = Imagename(j);
            id = dt.Rows[j][0].ToString();
            // string[] items = {hh};
            string posterUrl = IDimage.IsUrlExist(id, Server.MapPath("~/image/"),"~/image/");

            //string posterUrl = wb.fillpicture(id);
            ImageButton imgbtn = new ImageButton { ImageUrl = Page.ResolveUrl(posterUrl), CssClass = "cool" };
            imgbtn.Click += new ImageClickEventHandler(ImageButton1_Click);
            imgbtn.ID = i.ToString();
             ctrl.Controls.Add(imgbtn);
            i++;
        }
        // replace with a placeHolder object
        PlaceHolder1.Controls.Add(ctrl);

    }

    private void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        string imagename = ((ImageButton)sender).ImageUrl.ToString();
        Session["url"] = imagename;
        Session["movieId"] = Path.GetFileNameWithoutExtension(imagename);
        Response.Redirect("reviewmovie.aspx");
    }
    
}
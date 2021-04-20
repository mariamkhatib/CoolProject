using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    public bool UserExist(string email)
    {
        string SqlStr = "select  [Email] from [UsersTbl] where [Email]='" + email + "'";
        DataTable dt = Dbase.SelectFromTable(SqlStr, "IDmovie.mdb");
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }

    protected void SignUp_Click(object sender, EventArgs e)
    {
       
        string fname = TextBox1.Text;
        string lname = TextBox2.Text;
        string email = TextBox3.Text;
        string password = TextBox4.Text;
        int age =int.Parse(TextBox5.Text);
        Users us = new Users();
        if (!Users.UserExist(email))
        {
            string usertype = "User";
            string strsql = "Insert into[UsersTbl]([FirstName],[LastName],[Email],[Password],[UserType],[Age])";
            strsql += "values('" + fname + "','" + lname + "','" + email + "','" + password + "','" + usertype + "','" + age + "')";
            Dbase Db = new Dbase();
            string filename = "IDmovie.mdb";
            Dbase.ChangeTable(strsql, filename);
          
                Response.Redirect("~/UserHome.aspx");
        }

        else
        {
            if (Users.UserExist(email))
            {
                Label5.Text = "you`re already signed up click on the Log in button";
                Label5.Visible = true;

            }
        }
      }
}






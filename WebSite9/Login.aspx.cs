using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

       // Users user = new Users();
        if (!Users.UserExist(TextBox1.Text))
        {
            Label3.Text = "you aren`t a user clik on the register botton";
            Label3.Visible = true;
        }
        else
        {
            if (Users.IsAdmin(TextBox1.Text))
            {
                Response.Redirect("~/Admin.aspx");
            }
            Response.Redirect("~/Home_User.aspx");
           
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Register.aspx");
    }
}
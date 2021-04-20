
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{
    public Users()
    {
              
    }

    public static bool UserExist(string email)
    {
        string SqlStr = "select  [Email] from [UsersTbl] where [Email]='" + email + "'";
        DataTable dt = Dbase.SelectFromTable(SqlStr, "IDmovie.mdb");
        if (dt.Rows.Count > 0)
            return true;
        
        return false;
    }

    public static int AddUser(string fname, string lname, string email, string password, string UserType,string age)
    {
        string insertQuery = "INSERT INTO [UsersTbl]([FirstName],[LastName],[Email],[Password],[UserType],[Age]) VALUES ('"
        + fname + "','" + lname + "','" + email + "','" + password + "','" + UserType + "','" + age + "')";

        string DbName = "IDmovie.mdb";
        return Dbase.ChangeTable(insertQuery, DbName);

    }
    public static bool IsAdmin(string email)
    {
        string SqlStr = "select  [Email],[UserType] from [UsersTbl] where [Email]='" + email + "'";
        DataTable dt = Dbase.SelectFromTable(SqlStr, "IDmovie.mdb");
        if (dt.Rows.Count > 0  && dt.Rows[0]["UserType"].Equals("Admin"))
            return true;

        return false;
    }

}
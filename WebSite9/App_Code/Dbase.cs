
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dBase
/// </summary>
public class Dbase
{
    public Dbase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static SqlConnection Connection { get; internal set; }
    public static int ExecuteNonQuery { get; private set; }

    public static OleDbConnection MakeConnection(string strFileName)
    {
        OleDbConnection c = new OleDbConnection();
        c.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        c.ConnectionString += HttpContext.Current.Server.MapPath("~/App_Data/" + strFileName);
        c.Open();
        return c;
    }


    public static DataTable SelectFromTable(string strSql, string strFileName)
    {
        OleDbConnection c = MakeConnection(strFileName);
        OleDbCommand comm = new OleDbCommand();
        comm.CommandText = strSql;
        comm.Connection = c;
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter(comm);
        da.Fill(dt);
        c.Close();
        return dt;
    }

    public static int ChangeTable(string strSql, string strFileName)
    {
        OleDbConnection c = MakeConnection(strFileName);
        OleDbCommand comm = new OleDbCommand();
        comm.CommandText = strSql;
        comm.Connection = c;
        int nAffectedRows = comm.ExecuteNonQuery();
        c.Close();
        return nAffectedRows;
    }
}
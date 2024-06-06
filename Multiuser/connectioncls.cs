using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Multiuser
{
    public class connectioncls
    {

        SqlConnection con;
        SqlCommand cmd;

        public connectioncls()
        {
            con = new SqlConnection(@"server=MSI\SQLEXPRESS;database=multiuser;Integrated Security=True");
        }
        public int fn_nonquery(string sqlquery)
        {
           
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string fn_scalar(string sqlquery)
        {
           
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;

        }
    }
}
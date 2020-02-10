using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class ADOlayer
    {
        string constr = "";
        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["my"].ConnectionString;
        }
        public void insertrow(string res_name, string res_location, string res_timings, string res_close)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@res_name", res_name);
                    cmd.Parameters.AddWithValue("@res_location", res_location);
                    cmd.Parameters.AddWithValue("@res_timings", res_timings);
                    cmd.Parameters.AddWithValue("@res_close", res_close);
                    cmd.CommandText = "InsertRecord";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        



    }
}

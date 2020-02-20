using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace projectfri
{
    public class ADOLayer
    {
        string constr = "";
        public ADOLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstr"].ConnectionString;
        }
        public DataSet getstu(int tid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.CommandText = "sbyid";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public void updatedata(int tid,string techdomain)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    //cmd.Parameters.AddWithValue("@tname", tname);
                   // cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@techdomain", techdomain);
                   // cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.CommandText = "update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
        public void insertrow(int tid, string tname, string tlocation, string techdomain,string StartDate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tId", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@techdomain", techdomain);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);

                    cmd.CommandText = "Insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from trainee";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
    }
}
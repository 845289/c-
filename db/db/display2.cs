using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db
{
    class display2
    {
        private string constring = "";

        public display2()
        {
            constring = @"Data Source=BLT1069\SQLEXPRESS2014;Initial Catalog=dileep;Integrated Security=True";
        }
        public display ShowbyId(int id)
        {
            string singleqry = "select * from restaurent where Id =" + id;
            display rtnt = new display();

            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(singleqry, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        rtnt = new display { Name = dr[0].ToString(), Id = Convert.ToInt32(dr[1]), Type = dr[2].ToString(), Location = dr[3].ToString() };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return rtnt;
            }
        }
        public void showmenu(display rt)
        {

            string insertqry = string.Format("insert into restaurent(name,id,type,location)values('{0}','{1}','{2}','{3}')", rt.Name, rt.Id, rt.Type, rt.Location);
            using (SqlConnection con = new SqlConnection(constring))
            {
                int i = 0;
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand(insertqry, con);
                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                // string querystr = "insert into restaure
                //string querystr = "select * from product";

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (i > 0)
                {
                    Console.WriteLine("restaurent details entered");
                }
            }

        }
    }
}
}

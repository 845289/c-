using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db
{
    class display
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }



        public void showrestaurent()
        {
            string constr = @"Data Source=BLT1069\SQLEXPRESS2014;Initial Catalog=dileep;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {

                    string querystr = "select * from restaurent";


                    //string querystr = "select * from product";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", reader[0], reader[1], reader[2], reader[3]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



    }
}
}

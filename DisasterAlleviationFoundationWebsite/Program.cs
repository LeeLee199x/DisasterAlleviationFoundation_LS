using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterAlleviationFoundationWebsite
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                string connectionString = Server = tcp:lerato.database.windows.net,1433; Initial Catalog =Disaster Alleviation Foundation; Persist Security Info = False; User ID = admin1; Password ='Seatleft21'; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("DJs in da house!");
                    Console.WriteLine("=========================================\n");
                    String sql = "SELECT * FROM DJ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} - {1}",
                                reader.GetInt32(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();

        }


    }
}

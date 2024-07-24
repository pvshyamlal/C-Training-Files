using System;
using System.Data.SqlClient;

namespace AdoConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=SHYAMLAL-HP\\SQLEXPRESS;database=shyam;integrated security=SSPI;");
                con.Open();
                Console.WriteLine("Connected Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

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
                SqlCommand s1 = new SqlCommand("INSERT INTO stu (id, name, branch) VALUES (1, 'shyam', 'Computer Science')", con);
                con.Open();
                s1.ExecuteNonQuery();
                Console.WriteLine("Data Insertion Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

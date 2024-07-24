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
                SqlCommand s1 = new SqlCommand("create table stu(id int not null, name varchar(20), branch varchar(20))", con);
                con.Open();
                s1.ExecuteNonQuery();
                Console.WriteLine("Table Created Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

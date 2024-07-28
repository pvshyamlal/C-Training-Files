using System;
using System.Data.SqlClient;
using System.Drawing;

namespace AdoConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;"))
            {
                con.Open();
                new Program().QueryTable(con);
            }
        }
public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;");
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

        public void InsertTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;");
                SqlCommand s1 = new SqlCommand("INSERT INTO stu (id, name, branch) VALUES (1, 'Sandeep', 'Computer Science')", con);
                SqlCommand s2 = new SqlCommand("INSERT INTO stu (id, name, branch) VALUES (2, 'Shyam', 'Computer Science')", con);
                con.Open();
                s1.ExecuteNonQuery();
                s2.ExecuteNonQuery();
                Console.WriteLine("Data Insertion Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public void ShowTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;");
                SqlCommand s1 = new SqlCommand("select * from stu;", con);
                con.Open();
                SqlDataReader r = s1.ExecuteReader();
                while (r.Read())
                {
                    Console.WriteLine("ID: " + r[0] + " Name: " + r[1] + " Branch: " + r[2]);
                }
                Console.WriteLine("Data Viewed Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public void DeleteTable()
        {
            using (SqlConnection con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS stu", con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table 'stu' deleted successfully.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
        public void InsertDataAndCountRows()
        {
            using (SqlConnection con = new SqlConnection("data source=SANDEEP-PC\\SQLEXPRESS;database=GEC;integrated security=SSPI;"))
            {
                con.Open();
                // Insert data into the table
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO stu (id, name, branch) VALUES (1, 'Sandeep', 'Computer Science')", con))
                {
                    insertCmd.ExecuteNonQuery();
                    Console.WriteLine("Data Insertion Successful");
                }

                // Count the number of rows in the table
                using (SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM stu", con))
                {
                    object result = countCmd.ExecuteScalar();
                    if (result != null)
                    {
                        int rowCount = Convert.ToInt32(result);
                        Console.WriteLine("Number of rows in 'stu' table: "+rowCount);
                    }
                }
            }
        }
        public void QueryTable(SqlConnection con)
        {
            var q = "select count(*) from stu;";
            var q1 = "INSERT INTO stu (id, name, branch) VALUES (1, 'Sandeep', 'Computer Science')";
           // var q2 = "alter table stu add phone varchar(20) null";
            var q3 = "update stu set phone='1234567890' where id=1";
            var q5 = "delete from stu where id=1";
            SqlCommand c = new SqlCommand(q, con);
            SqlCommand c1 = new SqlCommand(q1, con);
           // SqlCommand c2 = new SqlCommand(q2, con);
            SqlCommand c3 = new SqlCommand(q3, con);
            SqlCommand c4 = new SqlCommand(q5, con);
            var reader = c.ExecuteScalar();
            var reader2 = c1.ExecuteScalar();
           // var reader3 = c2.ExecuteScalar();
            var reader4 = c3.ExecuteScalar();
            var reader5 = c4.ExecuteScalar();
            Console.WriteLine(reader);
            Console.WriteLine(reader2);
           // Console.WriteLine(reader3);
            Console.WriteLine(reader4);
            Console.WriteLine(reader5);
            Console.WriteLine("Data Inserted and Deleted Successfully");
        }
    }
}

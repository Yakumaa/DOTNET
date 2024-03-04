using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    internal class Crud
    {
        public void CreateTable()
        {
            // Connection string
            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";

            // Connecting to the database
            using (SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();

                    // Writing table creation query
                    string tblQuery = "CREATE TABLE tbl_std(id INT PRIMARY KEY, " +
                                      "name VARCHAR(50), gender VARCHAR(50), " +
                                      "faculty VARCHAR(50), fee VARCHAR(50))";

                    // Executing the query
                    using (SqlCommand cmd = new SqlCommand(tblQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table created");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void InsertData()
        {
            // Connection string
            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";

            // Connecting to the database
            using (SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();

                    // Inserting data query
                    string insQuery = "INSERT INTO tbl_std VALUES (1, 'Anjeep', 'NA', 'CSIT', '69000')";

                    // Executing the query
                    using (SqlCommand cmd = new SqlCommand(insQuery, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data inserted");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void fetchData()
        {
            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string disQuery = "select * from tbl_std";
                SqlCommand sc = new SqlCommand(disQuery, conn);
                SqlDataReader row = sc.ExecuteReader();
                while (row.Read())
                {
                    Console.WriteLine("id is " + row["id"]);
                    Console.WriteLine("name is " + row["name"]);
                    Console.WriteLine("gender is " + row["gender"]);
                    Console.WriteLine("faculty is " + row["faculty"]);
                    Console.WriteLine("fee is " + row["fee"]);
                    Console.WriteLine("----------------------");
                }
            }catch(SqlException s)
            {
                Console.WriteLine(s);
            }
        }

        public void updateData()
        {
            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string upQuery = "update tbl_std set name= @name, gender= @gender, faculty=@faculty where id= @id";
                Console.WriteLine("enter id of student for which you want to update");
                string upId = Console.ReadLine();
                Console.WriteLine("enter updated name ");
                string upName = Console.ReadLine();
                Console.WriteLine("enter updated gender ");
                string upGender = Console.ReadLine();
                Console.WriteLine("enter updated faculty ");
                string upFaculty = Console.ReadLine();
                
                SqlCommand sc = new SqlCommand(upQuery, conn);
                sc.Parameters.AddWithValue("@id", upId);
                sc.Parameters.AddWithValue("@name", upName);
                sc.Parameters.AddWithValue("@gender", upGender);
                sc.Parameters.AddWithValue("@faculty", upFaculty);

                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + "record updated");
                }
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }

        public void deleteData()
        {
            string cs = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string delQuery = "delete from tbl_std where id= @id";
                Console.WriteLine("enter id of student for which you want to deleted");
                string delId = Console.ReadLine();

                SqlCommand sc = new SqlCommand(delQuery, conn);
                sc.Parameters.AddWithValue("@id", delId);

                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + "record deleted");
                }
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}


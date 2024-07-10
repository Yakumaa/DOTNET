using System;
using System.Data.SqlClient;

public class Registration
{
    private static string connectionString = "Data Source=SHRIJALA-PC\\SQLEXPRESS;Initial Catalog=db_prime;Integrated Security=True";

    public static void CreateTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbl_registration' and xtype='U')
                CREATE TABLE tbl_registration (
                    id INT PRIMARY KEY IDENTITY(1,1),
                    username VARCHAR(50),
                    password VARCHAR(50),
                    repassword VARCHAR(50),
                    gender VARCHAR(10),
                    course VARCHAR(50),
                    country VARCHAR(50)
                )";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Table created successfully.");
            }
        }
    }

    public static void InsertData()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO tbl_registration (username, password, repassword, gender, course, country) 
                             VALUES (@username, @password, @repassword, @gender, @course, @country)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Console.Write("Enter username: ");
                command.Parameters.AddWithValue("@username", Console.ReadLine());

                Console.Write("Enter password: ");
                command.Parameters.AddWithValue("@password", Console.ReadLine());

                Console.Write("Re-enter password: ");
                command.Parameters.AddWithValue("@repassword", Console.ReadLine());

                Console.Write("Enter gender: ");
                command.Parameters.AddWithValue("@gender", Console.ReadLine());

                Console.Write("Enter course: ");
                command.Parameters.AddWithValue("@course", Console.ReadLine());

                Console.Write("Enter country: ");
                command.Parameters.AddWithValue("@country", Console.ReadLine());

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Data inserted successfully.");
                else
                    Console.WriteLine("Failed to insert data.");
            }
        }
    }

    public static void DisplayAllRecords()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM tbl_registration";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Username: {reader["username"]}, Gender: {reader["gender"]}, Course: {reader["course"]}, Country: {reader["country"]}");
                }
                reader.Close();
            }
        }
    }

    public static void UpdateRecord()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE tbl_registration SET username = @username, course = @course WHERE id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Console.Write("Enter ID to update: ");
                command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));

                Console.Write("Enter new username: ");
                command.Parameters.AddWithValue("@username", Console.ReadLine());

                Console.Write("Enter new course: ");
                command.Parameters.AddWithValue("@course", Console.ReadLine());

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Record updated successfully.");
                else
                    Console.WriteLine("Failed to update record.");
            }
        }
    }

    public static void DeleteRecord()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM tbl_registration WHERE id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Console.Write("Enter ID to delete: ");
                command.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Record deleted successfully.");
                else
                    Console.WriteLine("Failed to delete record.");
            }
        }
    }

    public static void DisplayMaleNepalRecords()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM tbl_registration WHERE gender = 'male' AND country = 'Nepal'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Username: {reader["username"]}, Gender: {reader["gender"]}, Course: {reader["course"]}, Country: {reader["country"]}");
                }
                reader.Close();
            }
        }
    }
}
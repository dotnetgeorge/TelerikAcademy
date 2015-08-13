using System;
using System.Data.SqlClient;

class NameAndDescriptionOfCategories
{
    static void Main(string[] args)
    {
        string connection = @"Server=JORO-PC;Database=Northwind;Integrated security=true";
        SqlConnection conn = new SqlConnection(connection);

        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT CategoryName, Description FROM Categories", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string name = "", description = "";

            Console.WriteLine("Category Name\t Description");
            using (reader)
            {
                while (reader.Read())
                {
                    name = (string)reader["CategoryName"];
                    description = (string)reader["Description"];

                    Console.WriteLine("{0}\t {1}", name, description);
                }
            }
        }
    }
}
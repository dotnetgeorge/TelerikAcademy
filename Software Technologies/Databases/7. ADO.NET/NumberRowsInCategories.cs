using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connection = @"Server=JORO-PC\;Database=Northwind;Integrated Security=true";
        SqlConnection conn = new SqlConnection(connection);
        SqlCommand cmd = new SqlCommand();
        int countOfCategories = 0;
        conn.Open();

        using (conn)
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Categories", conn);
            countOfCategories = (int)cmd.ExecuteScalar();
            Console.WriteLine("Count of Categories is: " + countOfCategories);
        }
    }
}
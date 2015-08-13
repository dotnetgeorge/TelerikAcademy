using System;
using System.Data.SqlClient;

class FindProduct
{
    static void Main(string[] args)
    {
        string connection = "Server=JORO-PC;Database=Northwind;Integrated security=true";
        SqlConnection conn = new SqlConnection(connection);

        Console.Write("Enter character or string to find: ");
        string find = @Console.ReadLine();

        conn.Open();
        using (conn)
        {
            using (SqlCommand cmd = new SqlCommand(@"SELECT ProductName FROM Products WHERE CHARINDEX(@Find, ProductName) > 0", conn))
            {
                cmd.Parameters.AddWithValue("@Find", find);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    string productName = "";

                    Console.WriteLine("All products containing {0} in name:", find);
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            productName = (string)reader["ProductName"];

                            Console.WriteLine(productName);
                        }
                    }
                }
                catch (SqlException se)
                {
                    Console.Error.WriteLine("SQL error occured: " + se.Message);
                }
            }
        }
    }
}
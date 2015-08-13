using System;
using System.Data.SqlClient;

class ProductCategoryAndNames
{
    static void Main(string[] args)
    {
        string connection = "Server=JORO-PC;Database=Northwind;Integrated security=true";
        SqlConnection conn = new SqlConnection(connection);
        string categoryName = "", productName = "";

        conn.Open();
        using (conn)
        {
            string query = "SELECT c.CategoryName, p.ProductName FROM Categories c JOIN Products p ON c.CategoryID = p.CategoryID GROUP BY c.CategoryName, p.ProductName";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Category Name\t Product Name");
            using (reader)
            {
                while (reader.Read())
                {
                    categoryName = (string)reader["CategoryName"];
                    productName = (string)reader["ProductName"];

                    Console.WriteLine("{0}\t {1}", categoryName, productName);
                }
            }
        }
    }
}
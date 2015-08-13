using System;
using System.Data.SqlClient;

class AddProduct
{
    static void Main(string[] args)
    {
        string connection = "Server=JORO-PC;Database=Northwind;Integrated security=true";

        using (SqlConnection conn = new SqlConnection(connection))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES(@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)", conn))
            {
                cmd.Parameters.AddWithValue("@ProductName", "Testing");
                cmd.Parameters.AddWithValue("@SupplierID", 1);
                cmd.Parameters.AddWithValue("@CategoryID", 1);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", "10 boxes");
                cmd.Parameters.AddWithValue("@UnitPrice", 15000);
                cmd.Parameters.AddWithValue("@UnitsInStock", 50);
                cmd.Parameters.AddWithValue("@UnitsOnOrder", 25);
                cmd.Parameters.AddWithValue("@ReorderLevel", 5);
                cmd.Parameters.AddWithValue("@Discontinued", true);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
using System;
using System.Data.OleDb;

class InsertIntoExcel
{
    static void Main(string[] args)
    {
        string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\InsertIntoExel.xls;Extended Properties='Excel 8.0;HDR=Yes;'";
        OleDbConnection conn = new OleDbConnection(connection);
        
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Score: ");
        double score = double.Parse(Console.ReadLine());

        conn.Open();
        using (conn)
        {
            using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [Sheet1$] VALUES(@Name, @Score)", conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Score", score);

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Successfully added to file.");
                }
                catch (OleDbException odbe)
                {
                    Console.Error.WriteLine("Problem occured: " + odbe.Message);
                }
            }
        }
    }
}
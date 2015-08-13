using System;
using System.Data.OleDb;

class ReadExelFile
{
    static void Main(string[] args)
    {
        string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\ReadExelFile.xls;Extended Properties='Excel 8.0;HDR=Yes;'";
        OleDbConnection conn = new OleDbConnection(connection);

        conn.Open();
        using (conn)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            string name = "";
            double score = 0;

            Console.WriteLine("Name\t\t Score");
            using (reader)
            {
                while (reader.Read())
                {
                    name = (string)reader["Name"];
                    score = (double)reader["Score"];

                    Console.WriteLine("{0}\t {1}", name, score);
                }
            }
        }
    }
}
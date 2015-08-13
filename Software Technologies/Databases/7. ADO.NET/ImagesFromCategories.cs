using System;
using System.Data.SqlClient;
using System.Drawing;

class ImagesFromCategories
{
    static void Main(string[] args)
    {
        string connection = "Server=JORO-PC;Database=Northwind;Integrated security=true";
        SqlConnection conn = new SqlConnection(connection);
        
        conn.Open();
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int index = 1;
            string fileName = "Picture" + index + ".jpg";

            using (reader)
            {
                while (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["Picture"];
                    Image picture = (Bitmap)((new ImageConverter()).ConvertFrom(imageBytes));
                    picture.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    index++;
                }
            }
        }
    }
}
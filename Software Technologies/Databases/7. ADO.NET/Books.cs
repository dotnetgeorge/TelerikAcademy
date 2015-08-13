using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Globalization;

class Books
{
    public static readonly string connection = "Server=localhost;Database=books;Uid=books;Pwd=books;charset=utf8;Convert Zero Datetime=True;Allow Zero Datetime=True";
    public static MySqlConnection conn = new MySqlConnection(connection);
    public static MySqlCommand cmd = new MySqlCommand();
    public static MySqlDataReader reader;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Show All Books");
            Console.WriteLine("2. Find Book");
            Console.WriteLine("3. Add Book");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if(choice == "4")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    ShowAllBooks();
                    break;
                case "2":
                    Console.Clear();
                    FindBook();
                    break;
                case "3":
                    Console.Clear();
                    AddBook();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select correct choice!");
                    break;
            }

        }
    }

    public static void ShowAllBooks()
    {
        conn.Open();
        using (conn)
        {
            cmd = new MySqlCommand("SELECT * FROM books", conn);

            try
            {
                reader = cmd.ExecuteReader();
                Console.WriteLine("Title\t Author\t PublishedDate\t ISBN");

                using (reader)
                {
                    while (reader.Read())
                    {
                        string title = (string)reader["Title"];
                        string author = (string)reader["Author"];
                        DateTime publishedDate = Convert.ToDateTime(reader["PublishedDate"]);
                        string isbn = (string)reader["ISBN"];

                        string date = publishedDate.ToString("dd-MM-yyyy");

                        Console.WriteLine("{0}\t {1}\t {2}\t {3}", title, author, date, isbn);
                    }
                }
            }
            catch (MySqlException mysqle)
            {
                Console.Error.WriteLine("MySQL error occured: " + mysqle.Message);
            }
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();
    }

    public static void FindBook()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        conn.Open();
        using (conn)
        {
            cmd = new MySqlCommand("SELECT * FROM Books WHERE title = @Title", conn);
            cmd.Parameters.AddWithValue("@Title", title);

            try
            {
                reader = cmd.ExecuteReader();

                Console.WriteLine("Title\t Author\t PublishedDate\t ISBN");

                using (reader)
                {
                    while (reader.Read())
                    {
                        title = (string)reader["Title"];
                        string author = (string)reader["Author"];
                        DateTime publishedDate = Convert.ToDateTime(reader["PublishedDate"]);
                        string isbn = (string)reader["ISBN"];

                        string date = publishedDate.ToString("dd-MM-yyyy");

                        Console.WriteLine("{0}\t {1}\t {2}\t {3}", title, author, date, isbn);
                    }
                }
            }
            catch (MySqlException mysqle)
            {
                Console.Error.WriteLine("MySQL error occured: " + mysqle.Message);
            }
        }

        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();
    }

    public static void AddBook()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Published date: ");
        DateTime publishedDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", new CultureInfo("en-US"), System.Globalization.DateTimeStyles.None);
        //string publishedDate = readDate.ToString("dd-MM-yyyy");
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();

        conn.Open();
        using (conn)
        {
            cmd = new MySqlCommand("INSERT INTO Books(Title,Author,PublishedDate,ISBN) VALUES(@Title,@Author,@PublishedDate,@ISBN)", conn);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@PublishedDate", publishedDate);
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Successfully added to database!");
            }
            catch (MySqlException mysqle)
            {
                Console.Error.WriteLine("MySQL error occured: " + mysqle.Message);
            }
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();
    }
}
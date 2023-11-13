/***
 * Author: Raymond Lawson
 * Purpose: This is the BibleVerseDAO class that handles communicating with the database. This class takes  in
 * data from the service class and parses the database depending on the request. This class then compiles the data
 * and returns it to the service class.
 * Date: 06/20/2023
 * ***/
using System.Collections.Generic;
using System.Data.SqlClient;
using BibleVerseApplication.Models;

namespace BibleVerseApplication.Services.Data
{
    public class BibleVerseDAO
    {
        //Connection string
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bible;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<BibleVerse> Search(BibleVerse verse)
        {
            //Create an empty list.
            List<BibleVerse> verseList = new List<BibleVerse>();

            //Create an empty string query.
            string query = "";

            //Use switch statement to determine old testament, new testament, or both.
            switch(verse.Testament)
            {
                case "Old":
                    {
                        //This query will only select records that are in the first 39 books (old testament)
                        query = "SELECT * FROM dbo.t_kjv WHERE t LIKE '%' + @Text + '%' AND b <= 39";
                        break;
                    }
                case "New":
                    {
                        //This query will only select records that are in the last 27 books (new testament)
                        query = "SELECT * FROM dbo.t_kjv WHERE t LIKE '%' + @Text + '%' AND b > 39";

                        break;
                    }
                case "Both":
                    {
                        //This query searches throughout the entire database.
                        query = "SELECT * FROM dbo.t_kjv WHERE t LIKE '%' + @Text + '%'";
                        break;
                    }
            }

            //Setup connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Text", verse.Text);

                //try/catch block incase errors when accessing the DB
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        //if the book is <= 39 it is part of the old  testament. 
                        if((int)reader[1] <= 39)
                        {
                            verse.Testament = "Old Testament";
                        }
                        else
                        {
                            verse.Testament = "New Testament";
                        }

                        //Create a BibleVerse object and save it to the list.
                        verseList.Add(new BibleVerse((int)reader[0], (int)reader[1], (int)reader[2], (int)reader[3], (string)reader[4], verse.Testament));

                    }
                }
                catch(SqlException e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }

                connection.Close();
            }
            
            //Return the List of BibleVerse objects.
            return verseList;
        }
    }
}

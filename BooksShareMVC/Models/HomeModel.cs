using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BooksShareMVC.Models
{
    public class HomeModel
    {
        public List<Book> GetBookDetails()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            con.Open();
            SqlDataReader reader;
            var qry = "select * from Books;";
            SqlCommand cmd = new SqlCommand(qry, con);
            reader = cmd.ExecuteReader();
            List<Book> lstBooks = new List<Book>();

            while (reader.Read())
            {
                lstBooks.Add(new Book
                {
                    ID = int.Parse(reader["ID"].ToString()),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString()
                });
            }

            return lstBooks;
        }
    }
}
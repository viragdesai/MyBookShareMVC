using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksShareMVC.Models
{
    public class Books
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        public int AuthorID { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }

        public int SalePrice { get; set; }

        public int CategoryID { get; set; }

        public DateTime PostedOn { get; set; }

        public int CityID { get; set; }
        
        public string Address { get; set; }
        
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "Language is Required")]
        public string Language { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public int PictureID { get; set; }

        public int ViewCount { get; set; }

        public int UserID { get; set; }
    }
}
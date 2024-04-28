using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Book_Detail
    {
        [Key]
        public int BookDetail_Id { get; set; }
        public int NumberOfPage { get; set; }
        public int NumberOfCapter { get; set; }
        public double Weight { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Book")]
        public int Book_Id { get; set; }
        public Book Book { get; set; }

    }
}

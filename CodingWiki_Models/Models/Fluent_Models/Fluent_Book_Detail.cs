using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Fluent_Book_Detail
    {

        public int BookDetail_Id { get; set; }
        public int NumberOfPage { get; set; }
        public int NumberOfCapter { get; set; }
        public double Weight { get; set; }

        public decimal Price { get; set; }

   
        public int Book_Id { get; set; }
        public Fluent_Book Book { get; set; }

    }
}

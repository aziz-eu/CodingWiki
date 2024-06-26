﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Fluent_Book
    {
    
        public int Id { get; set; }
        public string Title { get; set; }


        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public double PriceRange { get; set; }

        public Fluent_Book_Detail BookDetail { get; set; }

 
        public int Publisher_Id { get; set; }
        public Fluent_Publisher Publisher { get; set; }
        public List <Fluent_Author> Author {  get; set; }
        public List<Fluent_BookAuthorMap> BookAuthorMaps { get; set; }
    }
}

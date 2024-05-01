﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Fluent_BookAuthorMap
    {
        public int Author_Id { get; set; }
        public int Book_Id { get; set; }

        public Fluent_Book Book { get; set; }
        public Fluent_Author Author { get; set; }
    }
}
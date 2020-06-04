using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Books
{
    public class Book
    {
        public string ISBN { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public string edition { get; set; }
        public string publishedDate { get; set; }
        public string image { get; set; }
        public string notes { get; set; }
    }
}

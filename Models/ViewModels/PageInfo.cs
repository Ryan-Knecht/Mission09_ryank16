using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBook { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //How many pages do we need 
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBook / BooksPerPage);
    }
}

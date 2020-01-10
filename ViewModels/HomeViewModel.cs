using Library2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Book> Books { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog
{
    class Book
    {
        private string title;
        private string author;
        private int publication;



        public string Title { get ; set ; }
        public string Author { get => author; set => author = value; }
        public int Publication { get => publication; set => publication = value; }
    }
}

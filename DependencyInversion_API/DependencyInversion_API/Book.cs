using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_API
{
    class Book : IBook
    {
        public Book()
        {
        }

        public Book(string title, List<string> reviews)
        {
            Title = title;
            Reviews = reviews;
        }
        

        public string Title { get; set; }
        public List<string> Reviews { get; set; }
    }
}

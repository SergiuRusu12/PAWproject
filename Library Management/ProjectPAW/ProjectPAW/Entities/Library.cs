using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class Library
    {
        public List<Book> Books { get; set; }
        public string Name { get; set; }
        public Library() { 
            Books = new List<Book>();
        }

        public Library(string name) :this()
        {
            Name = name;
        }

        public Library(List<Book> books)
        {
            Books = books;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class Book
    {
        public int bookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public Book(int bookId, string Title, string AuthorName)
        {
            this.bookId = bookId;
            this.Title = Title;
            this.AuthorName = AuthorName;
        }

        public Book() { }

    }
}

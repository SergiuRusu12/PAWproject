using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Entities
{
    [Serializable]
    public class Lending
    {
        Random rnd = new Random();
        private AllReaders AllReaders;
        private Library AllBooks;
        private static int nextLendingId = 1;

        public int lendingId { get; set; }
        public int readerId { get; set; }
        public string readerName { get; set; }
        public string bookTitle { get; set; }
        public int bookId { get; set; }


        public Lending(int lendingId, int readerId, string readerName, string bookTitle, int bookId, AllReaders allReaders, Library allBooks)
        {
            this.lendingId = lendingId;
            this.readerId = readerId;
            this.readerName = readerName;
            this.bookTitle = bookTitle;
            this.bookId = bookId;
            this.AllReaders = allReaders;
            this.AllBooks = allBooks;
        }

        public static void SetNextLendingId(int id)
        {
            nextLendingId = id;
        }
        public Lending()
        {

            lendingId = nextLendingId;
            AllReaders = new AllReaders();
            AllBooks = new Library();
        }


        public override string ToString()
        {
            int readerId = FindReaderIdByName(readerName);
            int bookId = FindBookIdByTitle(bookTitle);

            return "Lending id: " + lendingId + " Reader id: " + readerId +
                " Reader name: " + readerName + " Book title: " + bookTitle +
                " Book id: " + bookId;
        }


        private int FindReaderIdByName(string readerName)
        {
            if (AllReaders != null && AllReaders.Readers != null)
            {
                foreach (var reader in AllReaders.Readers)
                {
                    if (reader.Name == readerName)
                    {
                        return reader.readerId;
                    }
                }
            }

          
            return rnd.Next(1, 10);
        }


        private int FindBookIdByTitle(string bookTitle)
        {
            if (AllBooks != null && AllBooks.Books != null)
            {
                foreach (var book in AllBooks.Books)
                {
                    if (book.Title == bookTitle)
                    {
                        return book.bookId;
                    }
                }
            }

            
            return rnd.Next(1, 10);
        }

    }


}
using System;

namespace model
{
    [Serializable]
    public class Book
    {

        private int bookId;
        private string password;
        private string title;
        private string author;
        private int available;

        public Book(int bookId, string password, string title, string author, int available)
        {
            this.bookId = bookId;
            this.password = password;
            this.title = title;
            this.author = author;
            this.available = available;
        }

        public string Author { get { return author; } set { author = value; } }

        string Title { get { return title; } set { title = value; } }

        int BookId { get{ return bookId; } set { bookId = value; } }

        int Available { get { return available; } set { available = value; } }

        public override string ToString()
        {
            return "[" + author + "," + title + "," + available + "]";
        }
        
    }
}

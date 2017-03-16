using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat
{
    public delegate void OnBookAdded(string title);
    class Library
    {
        public event OnBookAdded BookAdded;

        List<Book> bookList = new List<Book>();

        public void Add(Book book)
        {
            this.bookList.Add(book);
            if(this.BookAdded != null)
            {
                this.BookAdded(book.Title);
            }
        }
    }
}

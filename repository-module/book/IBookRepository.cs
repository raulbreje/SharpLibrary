using System.Collections.Generic;
using model;

namespace repository.book
{
    interface IBookRepository
    {
        List<IBookRepository> getAvailableBooks();
        List<Book> getUserBooks(int userId);
        List<Book> searchBooks(string key);
        int borrowBook(int userId, int bookId);
        Book returnBook(int userId, int bookId);
    }
}

using CoreTrainingDayTwo08122024.Models;

namespace CoreTrainingDayTwo08122024.Services
{
    public interface IBookService
    {

        Book AddBook(Book book);
        Book GetBookById(int id);

        List<Book> GetAllBooks();
        bool updateBook(int id, Book book);

        bool DeleteBook (int id);

    }
}

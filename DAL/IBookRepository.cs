using CoreTrainingDayTwo08122024.Models;

namespace CoreTrainingDayTwo08122024.DAL
{
    public interface IBookRepository
    {
        Book AddBook(Book book);
        Book GetBookbyId(int id);
        List<Book> GetBooks();
        bool UpdateBook(int id, Book book);
        bool DeleteBook(int id);

    }
}

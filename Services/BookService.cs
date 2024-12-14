using CoreTrainingDayTwo08122024.DAL;
using CoreTrainingDayTwo08122024.Exceptions;
using CoreTrainingDayTwo08122024.Models;

namespace CoreTrainingDayTwo08122024.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository repo;

        public BookService(IBookRepository _repo)
        {
            repo = _repo;
        }
        public Book AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        public bool DeleteBook(int id)
        {
            bool result = repo.DeleteBook(id);
            return result ? result : throw new BookNotFoundException($"Book with id {id} does not exist.");
        }

        public List<Book> GetAllBooks()
        {
            return repo.GetBooks();
        }

        public Book GetBookById(int id)
        {
            var book = repo.GetBookbyId(id);
            return book ?? throw new BookNotFoundException($"Book with id {id} does not exist.");
        }

        public bool updateBook(int id, Book book)
        {
            if(!repo.UpdateBook(id, book)) 
                throw new BookNotFoundException($"Book with id {id} does not exist.");
            else return true;
        }
    }
}

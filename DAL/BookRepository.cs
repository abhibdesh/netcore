using CoreTrainingDayTwo08122024.Models;

namespace CoreTrainingDayTwo08122024.DAL
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDataContext db;

        public BookRepository(BookDataContext _db)
        {
            db = _db;
        }
        public Book AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return book;
        }

        public bool DeleteBook(int id)
        {
            List<Book> list = db.Books.ToList();
            var book = (from b in list where b.BookId == id select b).FirstOrDefault();
            if (book == null) { 
                return false;
            }
            else
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return true;
            }
        }

        public Book GetBookbyId(int id)
        {
            List<Book> list = db.Books.ToList();
            Book book = list.Where(b => b.BookId == id).FirstOrDefault();
            return book;
        }

        public List<Book> GetBooks()
        {

            List<Book> list = db.Books.ToList();
            return list;
        }

        public bool UpdateBook(int id, Book book)
        {
            db.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            int rowsAffected = db.SaveChanges();
            return rowsAffected > 0 ? true : false;
        }
    }
}

using LibraryWebAPI.Data;
using LibraryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryWebAPI.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly LibraryDbContext _db; //to access Dbcontext which is DbSet

        public LibraryRepository(LibraryDbContext db) // to get the above content 
        {
            _db = db;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.ToListAsync();   //.Books refers DbSet's name
        }

        public async Task<Book> GetBookByName(string name)
        {
            var book = await _db.Books.FirstOrDefaultAsync(books => books.Title == name);
            return book;
        }

        public Task<Book> PostBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book> PutBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

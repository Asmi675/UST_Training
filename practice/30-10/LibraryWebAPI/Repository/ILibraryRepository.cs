using LibraryWebAPI.Models;

namespace LibraryWebAPI.Repository
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Book>> GetAllBooks(); //list of books to be displied
        Task<Book> GetBookByName(string name);
        Task<Book> PostBook(Book book);//adding book
        Task<Book> PutBook(Book book);//updating book
        Task<bool> DeleteBook(Book book);//deleting book
    }
}

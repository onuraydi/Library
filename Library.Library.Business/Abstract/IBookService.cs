using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        List<Book> GetAll();
        //List<Book> GetBooksByCategory(int CategoryID)   // ilerleyen zamanlarda kategorize edilebilrie
        List<Book> GetBooksByBookTitle(string BookTitle);
        List<Book> GetBooksByStatus(int StatusID);
        List<Book> GetBooksByAuthor(string Author);
    }
}

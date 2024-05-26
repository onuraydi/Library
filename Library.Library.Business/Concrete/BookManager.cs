
using Library.Library.Business.Abstract;
using Library.Library.Business.Utilities;
using Library.Library.Business.ValidationRules.FluentValidation;
using Library.Library.DataAccess.Abstract;
using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            try
            {
                _bookDal.Delete(book);
            }
            catch
            {
                throw new Exception("Delete Failed!!");
            }
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBooksByAuthor(string Author)
        {
            return _bookDal.GetAll(p => p.Author == Author);
        }

        public List<Book> GetBooksByBookTitle(string BookTitle)
        {
            return _bookDal.GetAll(p => p.BookTitle == BookTitle);
        }


        public List<Book> GetBooksByStatus(int StatusID)
        {
            return _bookDal.GetAll(p => p.StatusID == StatusID);
        }

        public void Update(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Update(book);
        }
    }
}

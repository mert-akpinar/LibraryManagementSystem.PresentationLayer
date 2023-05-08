using LibraryManagementSystem.BusinessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.Abstract;
using LibraryManagementSystem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TDelete(Book t)
        {
            _bookDal.Delete(t);
        }

        public Book TGetByID(int id)
        {
            return _bookDal.GetById(id);
        }

        public List<Book> TGetList()
        {
            return _bookDal.GetList();
        }

        public List<Book> TGetListBookWithAuthorANDCategory()
        {
            return _bookDal.GetListBookWithAuthorANDCategory();
        }

        public void TInsert(Book t)
        {
           _bookDal.Insert(t);
        }
        public void TUpdate(Book t)
        {
            _bookDal.Update(t);
        }
    }
}

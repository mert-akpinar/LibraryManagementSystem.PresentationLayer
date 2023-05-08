using LibraryManagementSystem.DataAccessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.Concrete;
using LibraryManagementSystem.DataAccessLayer.Repositories;
using LibraryManagementSystem.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepositories<Book>, IBookDal
    {    

        public List<Book> GetListBookWithAuthorANDCategory()
        {
            using var context = new Context();
            return context.Books.Include(x => x.Author).Include(y=>y.Category).ToList();
        }
    }
}

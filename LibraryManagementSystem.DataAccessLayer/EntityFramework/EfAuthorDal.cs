using LibraryManagementSystem.DataAccessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.Repositories;
using LibraryManagementSystem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer.EntityFramework
{
    public class EfAuthorDal : GenericRepositories<Author>,IAuthorDal
    {
    }
}

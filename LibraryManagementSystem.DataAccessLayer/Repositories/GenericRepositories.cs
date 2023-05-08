using LibraryManagementSystem.DataAccessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public GenericRepositories()
        {
            _object = context.Set<T>();
        }
        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            _object.Update(t);
            context.SaveChanges();
        }        
    }
}

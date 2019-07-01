using RBlog.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Repository.Data
{
    public interface IRepository<T> where T : BaseClass
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}

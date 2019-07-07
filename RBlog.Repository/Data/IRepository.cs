using RBlog.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Repository.Data
{
    public interface IRepository<T> where T : BaseClass
    {
        void Insert(T entity);
        void SaveChanges();
    }
}

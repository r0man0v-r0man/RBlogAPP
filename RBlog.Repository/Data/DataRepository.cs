using Microsoft.EntityFrameworkCore;
using RBlog.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBlog.Repository.Data
{
    public class DataRepository<T> : IRepository<T> where T : BaseClass
    {
        private readonly DataContext context;
        private DbSet<T> entities;
        public DataRepository(DataContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}

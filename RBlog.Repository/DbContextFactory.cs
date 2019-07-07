using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RBlog.Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Repository
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        private static string DataConnectionString => new DataBaseConfiguration().GetDataConnectionString();
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(DataConnectionString);
            return new DataContext(optionsBuilder.Options);
        }
    }
}

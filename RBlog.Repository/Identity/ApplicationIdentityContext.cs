﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Repository.Identity
{
    public class ApplicationIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityContext(DbContextOptions<ApplicationIdentityContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

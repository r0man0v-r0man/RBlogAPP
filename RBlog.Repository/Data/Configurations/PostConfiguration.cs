using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RBlog.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Repository.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(c => c.User)
                .WithMany(p => p.Posts)
                .HasForeignKey(c => c.UserId);
        }
    }
}

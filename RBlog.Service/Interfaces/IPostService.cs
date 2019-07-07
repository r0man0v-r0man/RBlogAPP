using RBlog.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Service.Interfaces
{
    public interface IPostService
    {
        void InsertPost(Post post);
    }
}

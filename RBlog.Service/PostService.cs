using RBlog.DATA.Entities;
using RBlog.Repository.Data;
using RBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> postRepository;
        public PostService(IRepository<Post> postRepository)
        {
            this.postRepository = postRepository;
        }
        public void InsertPost(Post post)
        {
            postRepository.Insert(post);
        }
    }
}

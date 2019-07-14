using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.DATA.Entities
{
    public class Post : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        //
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}

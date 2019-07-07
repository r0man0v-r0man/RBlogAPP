using System;
using System.Collections.Generic;
using System.Text;

namespace RBlog.DATA.Entities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RBlog.DATA.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Post> Posts { get; set; }
    }
}

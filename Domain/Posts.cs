using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Posts
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blogs Blogs { get; set; }
    }
}

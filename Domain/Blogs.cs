using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Blogs
    {
        public Guid Id { get; set; }
        public string Url { get; set; }

        public List<Posts> Posts { get; set; }
    }
}


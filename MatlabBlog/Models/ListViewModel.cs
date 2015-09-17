using MatlabBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatlabBlog.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }
    }
}
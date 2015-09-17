using MatlabBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBlog.Core
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int PageSize);
        int TotalPosts();
    }
}

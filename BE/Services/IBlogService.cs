using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBlogService
    {
        public Task<Blog> AddBlog(Blog blog);
        public Task<bool> DeleteBlog(int id);
        public Task<Blog> GetBlog(int id);
        public Task<List<Blog>> GetBlogs();
        public Task<Blog> UpdateBlog(Blog blogRequest, int id);
    }
}

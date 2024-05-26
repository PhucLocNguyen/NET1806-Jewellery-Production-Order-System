using BusinessObject;
using JewelleryDAOs;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository blogRepository;
        public BlogService()
        {
            blogRepository = new BlogRepository();  
        }

        public Task<Blog> AddBlog(Blog blog)
        {
            return blogRepository.AddBlog(blog);
        }

        public Task<bool> DeleteBlog(int id)
        {
            return blogRepository.DeleteBlog(id);
        }

        public Task<Blog> GetBlog(int id)
        {
            return blogRepository.GetBlog(id);
        }

        public Task<List<Blog>> GetBlogs()
        {
            return blogRepository.GetBlogs();
        }

        public Task<Blog> UpdateBlog(Blog blogRequest, int id)
        {
            return blogRepository.UpdateBlog(blogRequest, id);
        }
    }
}

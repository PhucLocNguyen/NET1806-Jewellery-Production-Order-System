using BusinessObject;
using JewelleryDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BlogRepository :IBlogRepository
    {
        private readonly JewelleryDAO jewelleryDAO;
        public BlogRepository()
        {
            jewelleryDAO = new JewelleryDAO();
        }

        public Task<Blog> AddBlog(Blog blog)
        {
            return jewelleryDAO.AddBlog(blog);
        }

        public Task<bool> DeleteBlog(int id)
        {
            return jewelleryDAO.DeleteBlog(id);
        }

        public Task<Blog> GetBlog(int id)
        {
            return jewelleryDAO.GetBlog(id);
        }

        public Task<List<Blog>> GetBlogs()
        {
            return jewelleryDAO.GetBlogs();
        }

        public Task<Blog> UpdateBlog(Blog blogRequest, int id)
        {
            return jewelleryDAO.UpdateBlog(blogRequest, id);
        }
    }
}

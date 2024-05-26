using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService blogService;

        public BlogsController()
        {
            if(blogService == null)
            {
                blogService = new BlogService();
            }
        }

        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs()
        {
            return await blogService.GetBlogs();
        }

        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await blogService.GetBlog(id);

            if (blog == null)
            {
                return NotFound();
            }

            return blog;
        }

        // PUT: api/Blogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlog(int id, Blog blogRequest)
        {
            if (id != blogRequest.BlogId)
            {
                return BadRequest();
            }

            var blog = blogService.UpdateBlog(blogRequest, id);
            if (blog == null)
            {
                return StatusCode(500);
            }


            return Ok(blog);
        }

        // POST: api/Blogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blog>> PostBlog(Blog blog)
        {
            blogService.AddBlog(blog);

            return CreatedAtAction("GetBlog", new { id = blog.BlogId }, blog);
        }

        // DELETE: api/Blogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var result = await blogService.DeleteBlog(id);
            if(!result)
            {
                return NotFound();
            }

            return Ok();
        }

       /* private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.BlogId == id);
        }*/
    }
}

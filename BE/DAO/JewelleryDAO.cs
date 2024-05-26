using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryDAOs
{
    public class JewelleryDAO
    {
        private readonly JewelleryOrderContext dbContext;

        public JewelleryDAO()
        {
            this.dbContext = new JewelleryOrderContext();
        }

        // Material CRUD Entity
        public async Task<List<MaterialDTO>> GetMaterials()
        {
            return await dbContext.Materials.ToListAsync();
        }

        public async Task<MaterialDTO> GetMaterial(int id)
        {
            return await dbContext.Materials.FirstOrDefaultAsync(x => x.MaterialId.Equals(id));
        }

        public async Task<MaterialDTO> AddMaterial(MaterialDTO material) 
        {
            await dbContext.Materials.AddAsync(material);
            await dbContext.SaveChangesAsync();
            return material;
        }
        

        public async Task<MaterialDTO> UpdateMaterial(MaterialDTO materialRequest, int id) 
        {
            var material = await dbContext.Materials.FirstOrDefaultAsync(x => x.MaterialId.Equals(id));
            if(material != null)
            {
                return material;
            }
            material.Name = materialRequest.Name;
            material.Price = materialRequest.Price;
            material.ManagerId = materialRequest.ManagerId;
            await dbContext.SaveChangesAsync();
            return material;
        }

        public async Task<bool> DeleteMaterial(int id)
        {
            var material = await dbContext.Materials.FirstOrDefaultAsync(x=> x.MaterialId.Equals(id));
            if(material == null )
            {
                return false;
            }
            dbContext.Materials.Remove(material);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // Blog CRUD Entity
        public async Task<List<Blog>> GetBlogs()
        {
            return await dbContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetBlog(int id)
        {
            return await dbContext.Blogs.FirstOrDefaultAsync(x => x.BlogId.Equals(id));
        }

        public async Task<Blog> AddBlog(Blog blog)
        {
            await dbContext.Blogs.AddAsync(blog);
            await dbContext.SaveChangesAsync();
            return blog;
        }


        public async Task<Blog> UpdateBlog(Blog blogRequest, int id)
        {
            var blog = await dbContext.Blogs.FirstOrDefaultAsync(x => x.BlogId.Equals(id));
            if (blog != null)
            {
                return blog;
            }
            blog.Title = blogRequest.Title;
            blog.Description = blogRequest.Description;
            blog.Image = blogRequest.Image;
            blog.ManagerId = blogRequest.ManagerId;
            await dbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<bool> DeleteBlog(int id)
        {
            var blog = await dbContext.Blogs.FirstOrDefaultAsync(x => x.BlogId.Equals(id));
            if (blog == null)
            {
                return false;
            }
            dbContext.Blogs.Remove(blog);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // Stone CRUD Entity
        public async Task<List<Stone>> GetStones()
        {
            return await dbContext.Stones.ToListAsync();
        }

        public async Task<Stone> GetStone(int id)
        {
            return await dbContext.Stones.FirstOrDefaultAsync(x => x.StonesId.Equals(id));
        }

        public async Task<Stone> AddStone(Stone stone)
        {
            await dbContext.Stones.AddAsync(stone);
            await dbContext.SaveChangesAsync();
            return stone;
        }

        public async Task<Stone> UpdateStone(Stone stoneRequest, int id)
        {
            var stone = await dbContext.Stones.FirstOrDefaultAsync(x => x.StonesId.Equals(id));
            if (stone != null)
            {
                return stone;
            }
            stone.Kind = stoneRequest.Kind;
            stone.Price = stoneRequest.Price;
            stone.Size = stoneRequest.Size;
            stone.Quantity = stoneRequest.Quantity;
            await dbContext.SaveChangesAsync();
            return stone;
        }

        public async Task<bool> DeleteStone(int id)
        {
            var stone = await dbContext.Stones.FirstOrDefaultAsync(x => x.StonesId.Equals(id));
            if (stone == null)
            {
                return false;
            }
            dbContext.Stones.Remove(stone);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // MasterGemstone CRUD Entity
        public async Task<List<MasterGemstone>> GetMasterGemstones()
        {
            return await dbContext.MasterGemstones.ToListAsync();
        }

        public async Task<MasterGemstone> GetMasterGemstone(int id)
        {
            return await dbContext.MasterGemstones.FirstOrDefaultAsync(x => x.MasterGemstoneId.Equals(id));
        }

        public async Task<MasterGemstone> AddMasterGemstone(MasterGemstone masterGemstone)
        {
            await dbContext.MasterGemstones.AddAsync(masterGemstone);
            await dbContext.SaveChangesAsync();
            return masterGemstone;
        }

        public async Task<MasterGemstone> UpdateMasterGemstone(MasterGemstone masterGemstoneRequest, int id)
        {
            var masterGemstone = await dbContext.MasterGemstones.FirstOrDefaultAsync(x => x.MasterGemstoneId.Equals(id));
            if (masterGemstone != null)
            {
                return masterGemstone;
            }
            masterGemstone.Kind =masterGemstoneRequest.Kind;
            masterGemstone.Size = masterGemstoneRequest.Size;
            masterGemstone.Price = masterGemstoneRequest.Price;
             await dbContext.SaveChangesAsync();
            return masterGemstone;
        }

        public async Task<bool> DeleteMasterGemstone(int id)
        {
            var masterGemstone = await dbContext.MasterGemstones.FirstOrDefaultAsync(x => x.MasterGemstoneId.Equals(id));
            if (masterGemstone == null)
            {
                return false;
            }
            dbContext.MasterGemstones.Remove(masterGemstone);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}

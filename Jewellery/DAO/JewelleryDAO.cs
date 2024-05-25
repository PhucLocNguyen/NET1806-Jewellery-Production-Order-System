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

        public async Task<List<Material>> GetMaterials()
        {
            return await dbContext.Materials.ToListAsync();
        }

        public async Task<Material> GetMaterial(int id)
        {
            return await dbContext.Materials.FirstOrDefaultAsync(x => x.MaterialId.Equals(id));
        }

        public async Task<Material> AddMaterial(Material material) 
        {
            await dbContext.Materials.AddAsync(material);
            await dbContext.SaveChangesAsync();
            return material;
        }
        

        public async Task<Material> UpdateMaterial(Material materialRequest, int id) 
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
    }
}

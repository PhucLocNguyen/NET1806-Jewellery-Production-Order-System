using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryServices
{
    public interface IMaterialService
    { 
        public Task<List<Material>> GetMaterials();
        public Task<Material> GetMaterial(int id);
        public Task<Material> AddMaterial(Material material);
        public Task<Material> UpdateMaterial(Material materialRequest, int id);
        public Task<bool> DeleteMaterial(int id);
    }
}

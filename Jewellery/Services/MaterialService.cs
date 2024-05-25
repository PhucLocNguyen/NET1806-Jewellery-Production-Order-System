using BusinessObject;
using JewelleryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryServices
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository materialRepository;

        public MaterialService()
        {
            this.materialRepository = new MaterialRepository();
        }

        public Task<Material> AddMaterial(Material material)
        {
            return materialRepository.AddMaterial(material);
        }

        public Task<bool> DeleteMaterial(int id)
        {
            return materialRepository.DeleteMaterial(id);
        }

        public Task<Material> GetMaterial(int id)
        {
            return materialRepository.GetMaterial(id);
        }

        public Task<List<Material>> GetMaterials()
        {
            return materialRepository.GetMaterials();
        }

        public Task<Material> UpdateMaterial(Material materialRequest, int id)
        {
            return materialRepository.UpdateMaterial(materialRequest, id);
        }
    }
}

using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryRepositories
{
    public interface IMaterialRepository
    {
        public Task<List<MaterialDTO>> GetMaterials();
        public Task<MaterialDTO> GetMaterial(int id);
        public Task<MaterialDTO> AddMaterial(MaterialDTO material);
        public Task<MaterialDTO> UpdateMaterial(MaterialDTO materialRequest, int id);
        public Task<bool> DeleteMaterial(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelleryDAOs;

using BusinessObject;

namespace JewelleryRepositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly JewelleryDAO jewelleryDAO;

        public MaterialRepository()
        {
            this.jewelleryDAO = new JewelleryDAO();
        }

        public Task<MaterialDTO> AddMaterial(MaterialDTO material)
        {
            return jewelleryDAO.AddMaterial(material);
        }

        public Task<bool> DeleteMaterial(int id)
        {
            return jewelleryDAO.DeleteMaterial(id);
        }

        public Task<MaterialDTO> GetMaterial(int id)
        {
            return jewelleryDAO.GetMaterial(id);
        }

        public Task<List<MaterialDTO>> GetMaterials()
        {
            return jewelleryDAO.GetMaterials();
        }

        public Task<MaterialDTO> UpdateMaterial(MaterialDTO materialRequest, int id)
        {
            return jewelleryDAO.UpdateMaterial(materialRequest, id);
        }
    }
}

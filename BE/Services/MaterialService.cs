﻿using BusinessObject;
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

        public Task<MaterialDTO> AddMaterial(MaterialDTO material)
        {
            return materialRepository.AddMaterial(material);
        }

        public Task<bool> DeleteMaterial(int id)
        {
            return materialRepository.DeleteMaterial(id);
        }

        public Task<MaterialDTO> GetMaterial(int id)
        {
            return materialRepository.GetMaterial(id);
        }

        public Task<List<MaterialDTO>> GetMaterials()
        {
            return materialRepository.GetMaterials();
        }

        public Task<MaterialDTO> UpdateMaterial(MaterialDTO materialRequest, int id)
        {
            return materialRepository.UpdateMaterial(materialRequest, id);
        }

        public static MaterialDTO toMatrerialDTO(this Material material) 
        {
            return new MaterialDTO()
            {
                MaterialId = material.MaterialId,
                Designs = material.Designs,
                Name = material.Name,
                Price = material.Price,
            };
        }
    }
}

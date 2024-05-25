using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using JewelleryServices;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly IMaterialService materialService ;

        public MaterialsController()
        {
            if(materialService == null)
            {
                materialService = new MaterialService();
            }
            
        }

        // GET: api/Materials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Material>>> GetMaterials()
        {
            return await materialService.GetMaterials();
        }

        // GET: api/Materials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Material>> GetMaterial(int id)
        {
            var material = await materialService.GetMaterial(id);

            if (material == null)
            {
                return NotFound();
            }

            return material;
        }

        // PUT: api/Materials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterial(int id, Material materialRequest)
        {
            if (id != materialRequest.MaterialId)
            {
                return BadRequest();
            }

           var material = await materialService.UpdateMaterial(materialRequest, id);
            if(material == null)
            {
                return StatusCode(500);
            }
            return Ok(material);
        }

        // POST: api/Materials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Material>> PostMaterial(Material material)
        {
           await materialService.AddMaterial(material);

            return CreatedAtAction("GetMaterial", new { id = material.MaterialId }, material);
        }

        // DELETE: api/Materials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterial(int id)
        {
            var result = await materialService.DeleteMaterial(id);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

       /* private bool MaterialExists(int id)
        {
            return _context.Materials.Any(e => e.MaterialId == id);
        }*/
    }
}

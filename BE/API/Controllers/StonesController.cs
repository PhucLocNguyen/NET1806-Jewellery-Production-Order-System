using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StonesController : ControllerBase
    {
        private readonly IStoneService stoneServices;

        public StonesController()
        {
            if(stoneServices == null)
            {
                stoneServices = new StoneService();
            }
        }

        // GET: api/Stones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stone>>> GetStones()
        {
            return await stoneServices.GetStones();
        }

        // GET: api/Stones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stone>> GetStone(int id)
        {
            var stone = await stoneServices.GetStone(id);

            if (stone == null)
            {
                return NotFound();
            }

            return stone;
        }

        // PUT: api/Stones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStone(int id, Stone stoneRequest)
        {
            if (id != stoneRequest.StonesId)
            {
                return BadRequest();
            }

            var stone = stoneServices.UpdateStone(stoneRequest, id);
            if (stone == null)
            {
                return StatusCode(500);
            }


            return Ok(stone);
        }

        // POST: api/Stones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stone>> PostStone(Stone stone)
        {
            stoneServices.AddStone(stone);

            return CreatedAtAction("GetStone", new { id = stone.StonesId }, stone);
        }

        // DELETE: api/Stones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStone(int id)
        {
            var result = await stoneServices.DeleteStone(id);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

       /* private bool StoneExists(int id)
        {
            return _context.Stones.Any(e => e.StonesId == id);
        }*/
    }
}

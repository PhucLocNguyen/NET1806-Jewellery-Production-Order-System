using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IStoneService
    {
        public Task<Stone> AddStone(Stone stone);
        public Task<bool> DeleteStone(int id);
        public Task<Stone> GetStone(int id);
        public Task<List<Stone>> GetStones();
        public Task<Stone> UpdateStone(Stone stoneRequest, int id);
    }
}

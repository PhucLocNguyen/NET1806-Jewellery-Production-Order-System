using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StoneService : IStoneService
    {
        private readonly IStoneRepository stoneRepository;
        public StoneService() 
        {
            stoneRepository = new StoneRepository();
        }
        public Task<Stone> AddStone(Stone stone)
        {
            return stoneRepository.AddStone(stone);
        }

        public Task<bool> DeleteStone(int id)
        {
            return stoneRepository.DeleteStone(id);
        }

        public Task<Stone> GetStone(int id)
        {
            return stoneRepository.GetStone(id);
        }

        public Task<List<Stone>> GetStones()
        {
            return stoneRepository.GetStones();
        }

        public Task<Stone> UpdateStone(Stone stoneRequest, int id)
        {
            return stoneRepository.UpdateStone(stoneRequest,id);

        }
    }
}

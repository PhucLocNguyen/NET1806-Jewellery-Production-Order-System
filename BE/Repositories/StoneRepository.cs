using BusinessObject;
using JewelleryDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StoneRepository : IStoneRepository
    {
        private readonly JewelleryDAO jewelleryDAO;

        public StoneRepository()
        {
            jewelleryDAO = new JewelleryDAO();
        }
        public Task<Stone> AddStone(Stone stone)
        {
            return jewelleryDAO.AddStone(stone);
        }

        public Task<bool> DeleteStone(int id)
        {
            return jewelleryDAO.DeleteStone(id);
        }

        public Task<Stone> GetStone(int id)
        {
            return jewelleryDAO.GetStone(id);
        }

        public Task<List<Stone>> GetStones()
        {
            return jewelleryDAO.GetStones();
        }

        public Task<Stone> UpdateStone(Stone stoneRequest, int id)
        {
            return jewelleryDAO.UpdateStone(stoneRequest, id);
        }
    }
}

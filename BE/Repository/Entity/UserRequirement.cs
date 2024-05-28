using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class UserRequirement
    {
        public int UserId { get; set; }
        public int RequirementId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Requirement Requirement { get; set; } = null!;
    }
}

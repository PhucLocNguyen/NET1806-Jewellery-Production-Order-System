using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class TypeOfJewellry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeOfJewelryId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class Stones
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StonesId { get; set; }
        [Required]
        public string Kind { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
    }

}

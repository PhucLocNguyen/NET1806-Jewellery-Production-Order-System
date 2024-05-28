using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class WarrantyCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarrantyCardId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(10)]
        public string Description { get; set; }

        public virtual ICollection<Have> Haves { get; set; } = new List<Have>();
    }

}

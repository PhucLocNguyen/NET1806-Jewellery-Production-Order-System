using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class Blog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public string? Image { get; set; }

        public int ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public virtual User Manager { get; set; }
    }
}

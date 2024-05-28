using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
public partial class Material
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaterialId { get; set; }
    [Required]

    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int ManagerId { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
    [ForeignKey(nameof(ManagerId))]
    public virtual User Manager { get; set; }
}

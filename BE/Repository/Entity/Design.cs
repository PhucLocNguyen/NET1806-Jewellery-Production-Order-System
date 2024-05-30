using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{ 
public partial class Design
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DesignId { get; set; }

    public int? ParentId { get; set; }

    public string? Image { get; set; }
    [Required]
    public string DesignName { get; set; }

    public decimal WeightOfMaterial { get; set; }

    public int? StonesId { get; set; }

    public int? MasterGemstoneId { get; set; }

    public int? ManagerId { get; set; }

    public int? TypeOfJewelryId { get; set; }

    public int? MaterialId { get; set; }
    [ForeignKey(nameof(ManagerId))]
    public virtual User? Manager { get; set; }
    [ForeignKey(nameof(MasterGemstoneId))]
    public virtual MasterGemstone? MasterGemstone { get; set; }
    [ForeignKey(nameof(MaterialId))]
    public virtual Material? Material { get; set; }

    public virtual ICollection<Requirement> Requirements { get; set; } = new List<Requirement>();
    [ForeignKey(nameof(StonesId))]
    public virtual Stones? Stone { get; set; }
    [ForeignKey(nameof(TypeOfJewelryId))]
    public virtual TypeOfJewellry? TypeOfJewelry { get; set; }
}

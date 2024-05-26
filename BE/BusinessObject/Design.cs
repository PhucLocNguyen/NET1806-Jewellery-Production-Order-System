using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Design
{
    public int DesignId { get; set; }

    public int? ParentId { get; set; }

    public string? Image { get; set; }

    public string DesignName { get; set; } = null!;

    public decimal? WeightOfMaterial { get; set; }

    public int? StonesId { get; set; }

    public int? MasterGemstoneId { get; set; }

    public int? ManagerId { get; set; }

    public int? TypeOfJewelryId { get; set; }

    public int? MaterialId { get; set; }

    public virtual User? Manager { get; set; }

    public virtual MasterGemstone? MasterGemstone { get; set; }

    public virtual MaterialDTO? Material { get; set; }

    public virtual ICollection<Requirement> Requirements { get; set; } = new List<Requirement>();

    public virtual Stone? Stones { get; set; }

    public virtual TypeOfJewelry? TypeOfJewelry { get; set; }
}

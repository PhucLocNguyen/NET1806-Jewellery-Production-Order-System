using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class MaterialDTO
{
    public int MaterialId { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Price { get; set; }

    public int? ManagerId { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();

}

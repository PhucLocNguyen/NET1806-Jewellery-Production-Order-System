using System;
using System.Collections.Generic;

namespace API;

public partial class MasterGemstone
{
    public int MasterGemstoneId { get; set; }

    public string Kind { get; set; } = null!;

    public string? Size { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
}

﻿using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Stone
{
    public int StonesId { get; set; }

    public string Kind { get; set; } = null!;

    public string? Size { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
}

using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class TypeOfJewelry
{
    public int TypeOfJewelryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
}

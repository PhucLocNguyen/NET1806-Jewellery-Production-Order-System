using System;
using System.Collections.Generic;

namespace API;

public partial class Requirement
{
    public int RequirementsId { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? ExpectedDelivery { get; set; }

    public string? Size { get; set; }

    public string? Design3D { get; set; }

    public decimal? GoldPriceAtMoment { get; set; }

    public decimal? StonePriceAtMoment { get; set; }

    public decimal? MatchingFee { get; set; }

    public decimal? TotalMoney { get; set; }

    public string? CustomerNote { get; set; }

    public string? SellerNote { get; set; }

    public int? DesignId { get; set; }

    public virtual Design? Design { get; set; }

    public virtual ICollection<Have> Haves { get; set; } = new List<Have>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

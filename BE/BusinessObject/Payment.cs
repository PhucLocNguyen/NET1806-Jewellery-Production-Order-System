using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Payment
{
    public int PaymentId { get; set; }

    public decimal Amount { get; set; }

    public string Method { get; set; } = null!;

    public DateOnly? CompletedAt { get; set; }

    public int? CustomerId { get; set; }

    public int? RequirementsId { get; set; }

    public virtual Requirement? Requirements { get; set; }
}

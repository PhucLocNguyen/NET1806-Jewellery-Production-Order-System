using System;
using System.Collections.Generic;

namespace Repository.Entity
{
    public partial class Have
    {
        public int WarrantyCardId { get; set; }

        public int RequirementsId { get; set; }

        public DateOnly? DateCreated { get; set; }

        public DateOnly? ExpirationDate { get; set; }

        public virtual Requirement Requirements { get; set; } = null!;

        public virtual WarrantyCard WarrantyCard { get; set; } = null!;
    }
}


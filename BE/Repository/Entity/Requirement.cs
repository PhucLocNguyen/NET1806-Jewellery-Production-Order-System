using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class Requirement
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequirementsId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateOnly ExpectedDelivery { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int DesignId { get; set; }
        [Required]
        public decimal GoldPriceAtMoment { get; set; }
        [Required]
        public decimal StonePriceAtMoment { get; set; }
        [Required]
        public decimal MatchingFee { get; set; }
        [Required]
        public decimal TotalMoney { get; set; }
        [Required]
        public string CustomerNote { get; set; }
        [Required]
        public string SaleStaffNote { get; set; }
        [ForeignKey(nameof(DesignId))]
        public virtual Design Design { get; set; }

        public virtual ICollection<Have> Haves { get; set; } = new List<Have>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }

}

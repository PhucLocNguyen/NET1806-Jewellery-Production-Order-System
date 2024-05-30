using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Method { get; set; }
        [Required]
        public DateOnly CompletedAt { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int RequirementsId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual User Customer { get; set; }
        [ForeignKey(nameof(RequirementsId))]
        public virtual Requirement Requirements { get; set; }
    }
}


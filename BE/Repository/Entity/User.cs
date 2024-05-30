using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entity
{
    public partial class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsersId { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

        public virtual ICollection<Design> Designs { get; set; } = new List<Design>();

        public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        [ForeignKey(nameof(RoleId))]
        public virtual Role? Role { get; set; }

        public virtual ICollection<Requirement> Requirements { get; set; } = new List<Requirement>();
    }
}


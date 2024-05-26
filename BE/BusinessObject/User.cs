﻿using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class User
{
    public int UsersId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public virtual ICollection<Design> Designs { get; set; } = new List<Design>();

    public virtual ICollection<MaterialDTO> Materials { get; set; } = new List<MaterialDTO>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Requirement> Requirements { get; set; } = new List<Requirement>();
}
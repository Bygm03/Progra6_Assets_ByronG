using System;
using System.Collections.Generic;

namespace Progra6_Assets_ByronG.Models;

public partial class User
{
    public int UserId { get; set; }

    public string CardId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public bool? Active { get; set; }

    public int UserRoleId { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual UserRole UserRole { get; set; } = null!;
}

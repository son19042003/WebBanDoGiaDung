using System;
using System.Collections.Generic;

namespace WebBanDoGiaDung.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PassEncode { get; set; }

    public string? Fullname { get; set; }

    public bool Active { get; set; }

    public int? RoleId { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual Role? Role { get; set; }
}

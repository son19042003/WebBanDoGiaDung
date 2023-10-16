﻿using System;
using System.Collections.Generic;

namespace WebBanDoGiaDung.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Fullname { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Avatar { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? LocationId { get; set; }

    public int? District { get; set; }

    public int? Ward { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Password { get; set; }

    public string? PassEncode { get; set; }

    public DateTime? LastLogin { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

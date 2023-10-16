using System;
using System.Collections.Generic;

namespace WebBanDoGiaDung.Models;

public partial class TransactStatus
{
    public int TransactStatusId { get; set; }

    public string? Status { get; set; }

    public string? Desciption { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

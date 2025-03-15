using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Supplier
{
    public int Supplierid { get; set; }

    public string Suppliername { get; set; } = null!;

    public string? Contactemail { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

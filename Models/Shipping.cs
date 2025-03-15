using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Shipping
{
    public int Shippingid { get; set; }

    public int? Orderid { get; set; }

    public string? Trackingnumber { get; set; }

    public string? Carrier { get; set; }

    public DateOnly? Estimateddelivery { get; set; }

    public string? Status { get; set; }

    public virtual Order? Order { get; set; }
}

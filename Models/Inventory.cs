using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Inventory
{
    public int Inventoryid { get; set; }

    public int? Productid { get; set; }

    public int Quantityavailable { get; set; }

    public DateTime? Lastrestock { get; set; }

    public virtual Product? Product { get; set; }
}

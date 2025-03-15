﻿using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Orderdetail
{
    public int Orderdetailid { get; set; }

    public int? Orderid { get; set; }

    public int? Productid { get; set; }

    public int Quantity { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}

﻿using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Wishlist
{
    public int Wishlistid { get; set; }

    public int? Userid { get; set; }

    public int? Productid { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}

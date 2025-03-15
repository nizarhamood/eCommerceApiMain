using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Review
{
    public int Reviewid { get; set; }

    public int? Userid { get; set; }

    public int? Productid { get; set; }

    public int? Rating { get; set; }

    public string? Reviewtext { get; set; }

    public DateTime? Createdat { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}

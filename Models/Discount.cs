using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Discount
{
    public int Discountid { get; set; }

    public string Code { get; set; } = null!;

    public decimal? Percentage { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }
}

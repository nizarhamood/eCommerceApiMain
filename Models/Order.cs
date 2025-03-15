using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int? Userid { get; set; }

    public decimal Totalamount { get; set; }

    public string? Status { get; set; }

    public DateTime? Createdat { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();

    public virtual User? User { get; set; }
}

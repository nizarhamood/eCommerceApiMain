using System;
using System.Collections.Generic;

namespace eCommerceApiMain.Models;

public partial class Payment
{
    public int Paymentid { get; set; }

    public int? Orderid { get; set; }

    public string? Paymentmethod { get; set; }

    public string? Paymentstatus { get; set; }

    public decimal Paidamount { get; set; }

    public DateTime? Createdat { get; set; }

    public virtual Order? Order { get; set; }
}

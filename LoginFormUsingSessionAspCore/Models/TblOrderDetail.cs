using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblOrderDetail
{
    public int OrderDetailId { get; set; }

    public string? ItemOrdered { get; set; }

    public string? CompanyOrderedFrom { get; set; }

    public string? Shippedby { get; set; }

    public string? ModelNumber { get; set; }

    public string? Color { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime? ArrivalNotificationDate { get; set; }

    public string? Orderstatus { get; set; }

    public int? OrderId { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedon { get; set; }

    public string? Updatedby { get; set; }

    public string? LinkToItemOrder { get; set; }

    public string? Comment { get; set; }

    public virtual TblOrder? Order { get; set; }
}

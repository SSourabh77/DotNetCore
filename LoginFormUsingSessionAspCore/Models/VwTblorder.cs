using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwTblorder
{
    public int OrderId { get; set; }

    public int? StaffId { get; set; }

    public string? Staffname { get; set; }

    public string? ItemOrdered { get; set; }

    public DateTime? OrderRequestDate { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal TotalCost { get; set; }

    public string? Orderstatus { get; set; }

    public DateTime? ApprovedByAccountsDate { get; set; }

    public bool ApprovalRequiredbyHead { get; set; }

    public DateTime? ApprovedByHeadDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblOrder
{
    public int OrderId { get; set; }

    public int? StaffId { get; set; }

    public string? EmailAddress { get; set; }

    public string? ItemOrdered { get; set; }

    public string? CompanyOrderedFrom { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactNumber { get; set; }

    public DateTime? OrderRequestDate { get; set; }

    public string? Department { get; set; }

    public int? ApprovedByAccountsCode { get; set; }

    public DateTime? ApprovedByAccountsDate { get; set; }

    public bool? ApprovalRequiredbyHead { get; set; }

    public int? ApprovedByHead { get; set; }

    public DateTime? ApprovedByHeadDate { get; set; }

    public string? Shippedby { get; set; }

    public DateTime? ArrivalNotificationDate { get; set; }

    public decimal? BudgetToBeCharged { get; set; }

    public string? ClassroomNumber { get; set; }

    public string? ModelNumber { get; set; }

    public string? Color { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalCost { get; set; }

    public string? CreditCardorChargeaccount { get; set; }

    public bool? DutyfreeLetterSent { get; set; }

    public bool? InvoiceSentToShipper { get; set; }

    public string? TrackingNumber { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? QuoteNumber { get; set; }

    public DateTime? DateqQoteApproved { get; set; }

    public string? Notes { get; set; }

    public string? Orderstatus { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedon { get; set; }

    public string? Updatedby { get; set; }

    public string? ToBeFilledBy { get; set; }

    public string? Attachment1 { get; set; }

    public string? Attachment2 { get; set; }

    public string? Attachment3 { get; set; }

    public string? Attachment4 { get; set; }

    public string? Attachment5 { get; set; }

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblWebHooksPaymentDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? JsonString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? OrderPaymentId { get; set; }

    public int? StudentId { get; set; }

    public int? Quantity { get; set; }

    public double? PTotal { get; set; }

    public double? STotal { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public string? UpnGoConfirmationNo { get; set; }

    public string? PaymentStatus { get; set; }
}

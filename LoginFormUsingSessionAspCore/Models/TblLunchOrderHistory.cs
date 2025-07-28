using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblLunchOrderHistory
{
    public int LunchOrderHistoryId { get; set; }

    public string StudentIdcard { get; set; } = null!;

    public DateOnly LunchDate { get; set; }

    public bool? Collected { get; set; }

    public bool? Billed { get; set; }

    public bool? Payed { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? OrderId { get; set; }

    public string? PricingType { get; set; }

    public bool? IsUpdatedOffline { get; set; }

    public bool? IsOffline { get; set; }

    public int? MeetTypeId { get; set; }

    public int? TblWebHooksPaymentDetailId { get; set; }
}

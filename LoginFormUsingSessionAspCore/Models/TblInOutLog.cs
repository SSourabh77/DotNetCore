using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblInOutLog
{
    public int InOutLogId { get; set; }

    public string? LogType { get; set; }

    public int? UserId { get; set; }

    public string? GuestName { get; set; }

    public int? ReasonId { get; set; }

    public string? GuestReason { get; set; }

    public string? OtherText { get; set; }

    public DateTime? InOutDateTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? GuestEmail { get; set; }

    public string? GuestPhoneNo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? Location { get; set; }

    public string? Clientip { get; set; }

    public string? UserNumber { get; set; }

    public string? HappinessLevel { get; set; }

    public int? HappinessRange { get; set; }

    public string? VisitorLocation { get; set; }
}

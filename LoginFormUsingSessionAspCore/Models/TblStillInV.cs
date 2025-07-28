using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblStillInV
{
    public int Id { get; set; }

    public DateOnly? LoginDay { get; set; }

    public string? GuestName { get; set; }

    public string? GuestEmail { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? Location { get; set; }
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblWeightRoomInOutLog
{
    public int InOutLogId { get; set; }

    public string? LogType { get; set; }

    public int? UserId { get; set; }

    public string? GuestName { get; set; }

    public string? GuestEmail { get; set; }

    public string? GuestPhoneNo { get; set; }

    public string? GuestReason { get; set; }

    public DateTime? InOutDateTime { get; set; }

    public bool Weights { get; set; }

    public bool Machines { get; set; }

    public bool AerobicEquipment { get; set; }

    public bool Floorworkout { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public DateTime? CheckOutDateTime { get; set; }

    public string? UserName { get; set; }
}

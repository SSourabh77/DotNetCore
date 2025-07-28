using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? Student { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Password { get; set; }

    public string? Title { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Dob { get; set; }

    public string? Reg { get; set; }

    public string? Year { get; set; }

    public string? House { get; set; }
}

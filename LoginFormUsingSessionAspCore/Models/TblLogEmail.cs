using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblLogEmail
{
    public int EmailLogId { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailBody { get; set; }

    public string? EmailType { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public DateTime? EmailDate { get; set; }

    public string? EmailStatus { get; set; }

    public long? RequestTimeTick { get; set; }

    public string? UniqueId { get; set; }
}

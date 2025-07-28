using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblEmailContent
{
    public int Id { get; set; }

    public string? Purpose { get; set; }

    public string? EmailType { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}

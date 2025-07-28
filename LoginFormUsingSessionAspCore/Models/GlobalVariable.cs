using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class GlobalVariable
{
    public int Id { get; set; }

    public string? VariableDescription { get; set; }

    public int? IntValue { get; set; }

    public string? TextValue { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}

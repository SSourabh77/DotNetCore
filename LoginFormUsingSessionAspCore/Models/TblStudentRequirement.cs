using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblStudentRequirement
{
    public int StudentRequirementId { get; set; }

    public int? StudentId { get; set; }

    public int? RequirementId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Notes { get; set; }

    public bool IsArchived { get; set; }

    public virtual TblRequirement? Requirement { get; set; }

    public virtual Student? Student { get; set; }
}

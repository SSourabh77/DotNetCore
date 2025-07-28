using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblRequirement
{
    public int RequirementId { get; set; }

    public string? RequirementDescription { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsArchived { get; set; }

    public virtual ICollection<TblStudentRequirement> TblStudentRequirements { get; set; } = new List<TblStudentRequirement>();
}

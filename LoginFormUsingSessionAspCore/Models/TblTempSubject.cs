using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblTempSubject
{
    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public string? QualificationId { get; set; }

    public string? Component { get; set; }

    public string? ExamDuration { get; set; }

    public string? ExamDate { get; set; }

    public string? SessionStartTime { get; set; }

    public string? Regular { get; set; }

    public string? Ilp { get; set; }

    public string? TotalStudents { get; set; }

    public string? YearGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool IsArchived { get; set; }

    public string? ActualStartTime { get; set; }

    public string? Comments { get; set; }
}

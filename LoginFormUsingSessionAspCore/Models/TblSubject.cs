using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblSubject
{
    public int SubjectId { get; set; }

    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public int? QualificationId { get; set; }

    public string? Component { get; set; }

    public DateTime? ExamDuration { get; set; }

    public DateTime? ExamDate { get; set; }

    public DateTime? SessionStartTime { get; set; }

    public int? Regular { get; set; }

    public string? Ilp { get; set; }

    public int? TotalStudents { get; set; }

    public string? YearGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsArchived { get; set; }

    public DateTime? ActualStartTime { get; set; }

    public virtual TblQualification? Qualification { get; set; }

    public virtual ICollection<TblStudentAssignedSubject> TblStudentAssignedSubjects { get; set; } = new List<TblStudentAssignedSubject>();
}

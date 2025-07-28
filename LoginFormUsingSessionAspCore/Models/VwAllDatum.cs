using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwAllDatum
{
    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int StudentId { get; set; }

    public int? QualificationId { get; set; }

    public string? QualificationName { get; set; }

    public string? QualificationCreatedBy { get; set; }

    public DateTime? QualificationCreatedOn { get; set; }

    public string? QualificationUpdatedBy { get; set; }

    public DateTime? QualificationUpdatedOn { get; set; }

    public bool? QualificationIsArchived { get; set; }

    public int? SubjectId { get; set; }

    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public string? Component { get; set; }

    public DateTime? ExamDuration { get; set; }

    public DateTime? ExamDate { get; set; }

    public DateTime? SessionStartTime { get; set; }

    public int? Regular { get; set; }

    public string? Ilp { get; set; }

    public int? TotalStudents { get; set; }

    public string? YearGroup { get; set; }

    public string? SubjectCreatedBy { get; set; }

    public DateTime? SubjectCreatedOn { get; set; }

    public string? SubjectUpdatedBy { get; set; }

    public DateTime? SubjectUpdatedOn { get; set; }

    public bool? SubjectIsArchived { get; set; }

    public int? RequirementId { get; set; }

    public string? RequirementDescription { get; set; }

    public string? RequirementCreatedBy { get; set; }

    public DateTime? RequirementCreatedOn { get; set; }

    public string? RequirementUpdatedBy { get; set; }

    public DateTime? RequirementUpdatedOn { get; set; }

    public bool? RequirementIsArchived { get; set; }

    public int StudentRequirementId { get; set; }

    public int? StudentRequirementStudentId { get; set; }

    public string? StudentRequirementCreatedBy { get; set; }

    public DateTime? StudentRequirementCreatedOn { get; set; }

    public string? StudentRequirementUpdatedBy { get; set; }

    public DateTime? StudentRequirementUpdatedOn { get; set; }

    public string? StudentRequirementNotes { get; set; }

    public bool StudentRequirementIsArchived { get; set; }

    public int? StudentAssignedtId { get; set; }

    public int? StudentAssignedStudentId { get; set; }

    public int? StudentAssignedSubjectId { get; set; }

    public string? StudentAssignedCreatedBy { get; set; }

    public DateTime? StudentAssignedCreatedOn { get; set; }

    public string? StudentAssignedUpdatedBy { get; set; }

    public DateTime? StudentAssignedUpdatedOn { get; set; }

    public string? StudentAssignedNotes { get; set; }

    public bool? StudentAssignedIsArchived { get; set; }

    public int? StudentAssignedRequirementId { get; set; }

    public string? StudentYearGroup { get; set; }
}

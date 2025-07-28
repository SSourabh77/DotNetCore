using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? StudentHomeroomId { get; set; }

    public string? StudentCode { get; set; }

    public string? ParentsEmail { get; set; }

    public int? HouseId { get; set; }

    public string? Password { get; set; }

    public string? YearGroup { get; set; }

    public DateTime? Dob { get; set; }

    public string? StudentsEmail { get; set; }

    public string? ParentPassword { get; set; }

    public string? ParentName { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public bool IsArchived { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FileName { get; set; }

    public string? UploadStudentPhoto { get; set; }

    public string? ParentsEmail2 { get; set; }

    public string? ParentPassword2 { get; set; }

    public string? StudentGender { get; set; }

    public string? ParentName2 { get; set; }

    public string? MobileNumber { get; set; }

    public string? ParentNumber2 { get; set; }

    public virtual ICollection<DeMeritEvent> DeMeritEvents { get; set; } = new List<DeMeritEvent>();

    public virtual ICollection<DeMeritWorkOffEvent> DeMeritWorkOffEvents { get; set; } = new List<DeMeritWorkOffEvent>();

    public virtual ICollection<HomeworkClubAttendance> HomeworkClubAttendances { get; set; } = new List<HomeworkClubAttendance>();

    public virtual House? House { get; set; }

    public virtual ICollection<LateHomework> LateHomeworks { get; set; } = new List<LateHomework>();

    public virtual ICollection<MeritEvent> MeritEvents { get; set; } = new List<MeritEvent>();

    public virtual ICollection<SatDetAttendance> SatDetAttendances { get; set; } = new List<SatDetAttendance>();

    public virtual Homeroom? StudentHomeroom { get; set; }

    public virtual ICollection<TblResult> TblResults { get; set; } = new List<TblResult>();

    public virtual ICollection<TblStudentAssignedSubject> TblStudentAssignedSubjects { get; set; } = new List<TblStudentAssignedSubject>();

    public virtual ICollection<TblStudentRequirement> TblStudentRequirements { get; set; } = new List<TblStudentRequirement>();
}

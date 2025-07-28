using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwColumnsPdf
{
    public long? Rownum { get; set; }

    public int StudentId { get; set; }

    public string? Term { get; set; }

    public string? UploadStudentPhoto { get; set; }

    public string? StudentName { get; set; }

    public int TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int ActivityId { get; set; }

    public string? ActivityName { get; set; }

    public string? HouseName { get; set; }

    public string? ParentsEmail { get; set; }

    public DateTime? Dob { get; set; }

    public string? StudentCode { get; set; }

    public string? YearGroup { get; set; }
}

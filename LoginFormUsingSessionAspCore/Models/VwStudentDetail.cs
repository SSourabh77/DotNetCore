using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwStudentDetail
{
    public int StudentId { get; set; }

    public string? YearGroup { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StudentName { get; set; }

    public string? HomeroomCode { get; set; }

    public bool IsArchived { get; set; }

    public string? UploadStudentPhoto { get; set; }

    public string? RequirementBalance { get; set; }
}

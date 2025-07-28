using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class CentralStudent
{
    public int StudentCentralId { get; set; }

    public string? SchoolIssuedId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StudentGender { get; set; }

    public DateTime? Dob { get; set; }

    public int? HouseId { get; set; }

    public string? YearGroup { get; set; }

    public string? RegGroup { get; set; }

    public string? HomeroomName { get; set; }

    public string? ParentEmail { get; set; }
}

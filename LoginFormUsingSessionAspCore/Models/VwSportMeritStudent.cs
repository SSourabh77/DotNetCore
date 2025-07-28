using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwSportMeritStudent
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? HouseId { get; set; }

    public string? HouseName { get; set; }

    public string? StudentName { get; set; }

    public string? UploadStudentPhoto { get; set; }
}

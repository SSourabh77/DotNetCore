using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TempStudent
{
    public int TempStudentid { get; set; }

    public string? StudentCode { get; set; }

    public string? StudentFirstName { get; set; }

    public string? StudentLastName { get; set; }

    public string? StudentEmailId { get; set; }

    public string? YearGroup { get; set; }

    public string? Dob { get; set; }

    public string? HomeroomCode { get; set; }

    public string? HouseName { get; set; }

    public string? ParentFirstName { get; set; }

    public string? ParentLastName { get; set; }

    public string? ParentEmailId { get; set; }

    public string? MobileNumber { get; set; }

    public string? Houseid { get; set; }

    public string? Homeroomid { get; set; }

    public string? FileName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ParentsEmail2 { get; set; }

    public string? ParentNumber2 { get; set; }

    public string? ParentFirstName2 { get; set; }

    public string? ParentLastName2 { get; set; }
}

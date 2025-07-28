using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class StudentsHistory
{
    public int StudentsHistoryId { get; set; }

    public int? StudentId { get; set; }

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

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FileName { get; set; }

    public string? Deletedby { get; set; }

    public DateTime? DeletedOn { get; set; }
}

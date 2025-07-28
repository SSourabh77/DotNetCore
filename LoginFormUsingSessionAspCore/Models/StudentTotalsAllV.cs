using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class StudentTotalsAllV
{
    public int StudentId { get; set; }

    public string? YearGroup { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? HomeroomCode { get; set; }

    public int DemApp { get; set; }

    public int Woapp { get; set; }

    public int MeritApp { get; set; }

    public int YearLateHw { get; set; }

    public int TotLateHw { get; set; }

    public int SatDetAtt { get; set; }

    public int Hwcatt { get; set; }

    public int? DemforSatDet { get; set; }

    public int? TotDem { get; set; }

    public int? TotalHwc { get; set; }

    public int? Hwcrem { get; set; }

    public int? SatDetRemCalc { get; set; }

    public string? StudentName { get; set; }

    public int? HomeroomId { get; set; }

    public int? HomeroomYear { get; set; }

    public int? SatDetRem { get; set; }

    public bool IsArchived { get; set; }

    public string? UploadStudentPhoto { get; set; }
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class SatDetListV
{
    public int SatDetId { get; set; }

    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? StudentHomeroomId { get; set; }

    public string? HomeroomCode { get; set; }

    public string? StudentCode { get; set; }
}

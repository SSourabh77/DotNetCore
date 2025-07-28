using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class SatDetRemV
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? HomeroomCode { get; set; }

    public int? SatDetRem { get; set; }
}

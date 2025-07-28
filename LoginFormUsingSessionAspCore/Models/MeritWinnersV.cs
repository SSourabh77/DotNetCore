using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class MeritWinnersV
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? SumOfMeritAmount { get; set; }

    public string? HomeroomCode { get; set; }

    public int? HomeroomYear { get; set; }

    public string? HouseName { get; set; }

    public DateTime? DateEntered { get; set; }
}

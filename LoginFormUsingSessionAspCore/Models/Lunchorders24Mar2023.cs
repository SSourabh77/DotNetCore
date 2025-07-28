using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class Lunchorders24Mar2023
{
    public int OrderId { get; set; }

    public string StudentIdcard { get; set; } = null!;

    public DateOnly LunchDate { get; set; }

    public bool? Collected { get; set; }

    public bool? Billed { get; set; }

    public bool? Payed { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int? MeetTypeId { get; set; }

    public string? PricingType { get; set; }
}

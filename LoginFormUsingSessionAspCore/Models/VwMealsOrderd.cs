using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwMealsOrderd
{
    public DateOnly LunchDate { get; set; }

    public string? LunchItem { get; set; }

    public int? Primary { get; set; }

    public int? Secondary { get; set; }

    public int? Teachers { get; set; }
}

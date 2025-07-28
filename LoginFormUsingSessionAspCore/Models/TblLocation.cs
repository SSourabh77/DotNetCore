using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblLocation
{
    public int Locid { get; set; }

    public string? LocationName { get; set; }

    public string? IsArchived { get; set; }

    public bool? CheckInCheckOutLocation { get; set; }

    public bool? VisitingLocation { get; set; }
}

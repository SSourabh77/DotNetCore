using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwNumberOfStudentsInHouse
{
    public int? EventId { get; set; }

    public int? HouseId { get; set; }

    public string? HouseName { get; set; }

    public int? NoOfStudents { get; set; }
}

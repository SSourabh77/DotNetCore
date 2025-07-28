using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class House
{
    public int HouseId { get; set; }

    public string? HouseName { get; set; }

    public int? TeacherId { get; set; }

    public bool IsArchived { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}

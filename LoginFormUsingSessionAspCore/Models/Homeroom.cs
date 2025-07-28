using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class Homeroom
{
    public int HomeroomId { get; set; }

    public string? HomeroomCode { get; set; }

    public int? HomeroomYear { get; set; }

    public int? TeacherId { get; set; }

    public bool IsArchived { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}

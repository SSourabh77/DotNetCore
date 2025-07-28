using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string TeacherName { get; set; } = null!;

    public int ClassAssign { get; set; }

    public decimal Salary { get; set; }
}

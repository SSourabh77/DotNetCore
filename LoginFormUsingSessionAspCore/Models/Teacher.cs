using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFormUsingSessionAspCore.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? TeacherCode { get; set; }

    public string? TeacherEmail { get; set; }

    public int? TeacherHomeroomId { get; set; }
    public string? TeacherPass { get; set; }

    public bool? Smt { get; set; }

    public bool? Ks2 { get; set; }

    public bool? Ks3 { get; set; }

    public bool? Ks4 { get; set; }

    public bool? Ib { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? Role { get; set; }

    public int? ActivityId { get; set; }

    public string? UploadTeacherPhoto { get; set; }

    public bool IsArchived { get; set; }

    public virtual ICollection<DeMeritEvent> DeMeritEvents { get; set; } = new List<DeMeritEvent>();

    public virtual ICollection<DeMeritWorkOffEvent> DeMeritWorkOffEvents { get; set; } = new List<DeMeritWorkOffEvent>();

    public virtual ICollection<HomeworkClubAttendance> HomeworkClubAttendances { get; set; } = new List<HomeworkClubAttendance>();

    public virtual ICollection<MeritEvent> MeritEvents { get; set; } = new List<MeritEvent>();

    public virtual ICollection<SatDetAttendance> SatDetAttendances { get; set; } = new List<SatDetAttendance>();

    public virtual Homeroom? TeacherHomeroom { get; set; }
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwDetailedExamSchedule
{
    public int SubjectId { get; set; }

    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public int? QualificationId { get; set; }

    public string? Component { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? ExamDateFormatted { get; set; }

    public DateTime? SessionStartTime { get; set; }

    public string? SessionStartTime24Hour { get; set; }

    public string? SessionStartTime12Hour { get; set; }

    public string? SessionEndTime24Hour { get; set; }

    public string? SessionEndTime12Hour { get; set; }

    public string? SessionEnd25PercentExtraTime24Hour { get; set; }

    public string? SessionEnd25PercentExtraTime12Hour { get; set; }

    public string? SessionEnd50PercentExtraTime24Hour { get; set; }

    public string? SessionEnd50PercentExtraTime12Hour { get; set; }

    public DateTime? ExamDuration { get; set; }

    public string? ExamDuration12Hour { get; set; }

    public string? ExamDurationMinutes { get; set; }

    public string? Extra25ExamDurationMinutes { get; set; }

    public string? ExamDuration24Hour { get; set; }

    public string? ExamDuration25PercentExtra { get; set; }

    public string? ExamDuration25PercentExtra12Hour { get; set; }

    public string? Extra50ExamDurationMinutes { get; set; }

    public string? ExamDuration50PercentExtra { get; set; }

    public string? ExamDuration50PercentExtra12Hour { get; set; }

    public string? YearGroup { get; set; }

    public bool IsArchived { get; set; }
}

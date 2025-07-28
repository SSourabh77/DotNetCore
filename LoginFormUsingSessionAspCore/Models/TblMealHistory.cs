using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblMealHistory
{
    public int MealHistoryId { get; set; }

    public DateOnly? MealDate { get; set; }

    public string? WeekDay { get; set; }

    public string? MealDesc { get; set; }

    public string? Week { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? MeatTypeId { get; set; }

    public string? MealShortDesc { get; set; }

    public decimal? MealCost { get; set; }

    public string? PrimarySecondary { get; set; }

    public string? MealCategory { get; set; }

    public bool? IsArchive { get; set; }
}

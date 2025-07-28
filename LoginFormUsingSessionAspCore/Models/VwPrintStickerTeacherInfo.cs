using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwPrintStickerTeacherInfo
{
    public int MeatTypeId { get; set; }

    public string? MealDesc { get; set; }

    public DateOnly? MealDate { get; set; }

    public string? TeacherName { get; set; }

    public string? TeacherCode { get; set; }

    public string? PricingTypeId { get; set; }

    public string PricingType { get; set; } = null!;

    public DateOnly? LunchDate { get; set; }
}

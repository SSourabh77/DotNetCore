using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwPrintPizzaStickerInfo
{
    public int PizzaMealsTypeId { get; set; }

    public string? MealDesc { get; set; }

    public DateOnly? MealDate { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StudentCode { get; set; }

    public string? Yeargroup { get; set; }

    public int? YearNo { get; set; }

    public string? PricingTypeId { get; set; }

    public string PricingType { get; set; } = null!;

    public DateOnly? LunchDate { get; set; }

    public string? PrimarySecondary { get; set; }

    public int? Slice { get; set; }

    public string? MealCategory { get; set; }

    public decimal? MealCost { get; set; }
}

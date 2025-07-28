using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class PizzaLunchOrder
{
    public int PizzaOrderId { get; set; }

    public string StudentIdcard { get; set; } = null!;

    public DateOnly LunchDate { get; set; }

    public bool? Collected { get; set; }

    public bool? Billed { get; set; }

    public bool? Payed { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public int? PizzaMealsTypeId { get; set; }

    public int? Slice { get; set; }

    public string? PricingType { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsUpdatedOffline { get; set; }

    public bool? IsOffline { get; set; }
}

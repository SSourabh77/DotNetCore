using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblPizzaLunchOrderHistory
{
    public int PizzaLunchOrderHistoryId { get; set; }

    public string StudentIdcard { get; set; } = null!;

    public DateOnly LunchDate { get; set; }

    public bool? Collected { get; set; }

    public bool? Billed { get; set; }

    public bool? Payed { get; set; }

    public int? Slice { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? PizzaOrderId { get; set; }

    public bool? IsUpdatedOffline { get; set; }

    public bool? IsOffline { get; set; }

    public int? PizzaMealsTypeId { get; set; }
}

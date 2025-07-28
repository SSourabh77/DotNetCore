using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class PizzaOrderPaymentDetail
{
    public int PizzaOrderPaymentDetailsId { get; set; }

    public string FullStudentName { get; set; } = null!;

    public int StudentId { get; set; }

    public string? Ccnumber { get; set; }

    public string? Ccname { get; set; }

    public string? Ccmonth { get; set; }

    public string? Ccyear { get; set; }

    public string? Cccvc { get; set; }

    public string? HomeRoom { get; set; }

    public string? ContactNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Notes { get; set; }

    public bool? PayCash { get; set; }

    public int? NumOfMeals { get; set; }

    public double? PTotal { get; set; }

    public double? STotal { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }
}

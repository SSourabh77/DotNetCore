using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwOrderPlacementReport
{
    public string? StudentCode { get; set; }

    public string? FullStudentName { get; set; }

    public string? ProductName { get; set; }

    public string? Size { get; set; }

    public decimal? SalePrice { get; set; }

    public string? ProductCategory { get; set; }

    public decimal? ProductSalePrice { get; set; }

    public string? Email { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentMode { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string Description1 { get; set; } = null!;

    public string? HomeRoom { get; set; }

    public string? TransactionId { get; set; }

    public string? DotNetResponce { get; set; }
}

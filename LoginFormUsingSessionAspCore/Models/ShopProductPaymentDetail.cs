using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class ShopProductPaymentDetail
{
    public int ShopProductPaymentDetailsId { get; set; }

    public int? ShopProductInventoryId { get; set; }

    public int? CartProductId { get; set; }

    public string? FullStudentName { get; set; }

    public int? StudentId { get; set; }

    public string? Ccnumber { get; set; }

    public string? Ccname { get; set; }

    public string? Ccmonth { get; set; }

    public string? Ccyear { get; set; }

    public string? Cccvc { get; set; }

    public string? OrderStatus { get; set; }

    public string? ContactNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Notes { get; set; }

    public bool? PayCash { get; set; }

    public bool? PaySchoolAccount { get; set; }

    public string? HomeRoom { get; set; }

    public int? NumOfOrders { get; set; }

    public double? PTotal { get; set; }

    public double? STotal { get; set; }

    public DateTime? OrderDate { get; set; }

    public double? MTotal { get; set; }

    public decimal? SalePrice { get; set; }

    public string? TransactionId { get; set; }

    public string? DotNetResponce { get; set; }

    public virtual TblShopProductInventory? ShopProductInventory { get; set; }
}

using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class ShopProductCart
{
    public int CartProductId { get; set; }

    public int? ShopProductId { get; set; }

    public int? ShopProductInventoryId { get; set; }

    public string? ProductSize { get; set; }

    public decimal? ProductSalePrice { get; set; }

    public string? StudentCode { get; set; }

    public string? Email { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentMode { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual TblShopProduct? ShopProduct { get; set; }

    public virtual TblShopProductInventory? ShopProductInventory { get; set; }
}

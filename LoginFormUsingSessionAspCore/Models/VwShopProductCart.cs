using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwShopProductCart
{
    public int CartProductId { get; set; }

    public int? ShopProductInventoryId { get; set; }

    public string? ProductName { get; set; }

    public decimal? SalePrice { get; set; }

    public string? ProductSize { get; set; }

    public decimal? ProductSalePrice { get; set; }

    public string? StudentCode { get; set; }

    public string? Email { get; set; }

    public string? OrderStatus { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? ProductCategory { get; set; }

    public decimal? InventoryQuantity { get; set; }

    public string? ImagePath { get; set; }
}

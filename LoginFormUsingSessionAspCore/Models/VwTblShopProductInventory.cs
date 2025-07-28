using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwTblShopProductInventory
{
    public int ShopProductId { get; set; }

    public int ShopProductInventoryId { get; set; }

    public bool IsArchive { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCategory { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? ImagePath { get; set; }

    public decimal? Quantity { get; set; }

    public string? Size { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }
}

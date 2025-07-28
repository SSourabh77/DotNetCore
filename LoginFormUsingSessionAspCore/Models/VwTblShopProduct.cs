using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwTblShopProduct
{
    public int ShopProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? ImagePath { get; set; }

    public string? ProductCategory { get; set; }

    public int? SizeCount { get; set; }

    public string? Size { get; set; }

    public decimal? SalePrice { get; set; }

    public int? IsArchive { get; set; }
}

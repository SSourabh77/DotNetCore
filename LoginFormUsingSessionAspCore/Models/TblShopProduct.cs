using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblShopProduct
{
    public int ShopProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? ImagePath { get; set; }

    public string? ProductCategory { get; set; }

    public bool? IsArchive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<ShopProductCart> ShopProductCarts { get; set; } = new List<ShopProductCart>();

    public virtual ICollection<TblShopProductInventory> TblShopProductInventories { get; set; } = new List<TblShopProductInventory>();
}

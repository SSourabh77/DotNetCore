using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblShopProductInventory
{
    public int ShopProductInventoryId { get; set; }

    public int? ShopProductId { get; set; }

    public string? Size { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public bool? IsArchive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual TblShopProduct? ShopProduct { get; set; }

    public virtual ICollection<ShopProductCart> ShopProductCarts { get; set; } = new List<ShopProductCart>();

    public virtual ICollection<ShopProductPaymentDetail> ShopProductPaymentDetails { get; set; } = new List<ShopProductPaymentDetail>();

    public virtual ICollection<TblShopProductSchoolOrder> TblShopProductSchoolOrders { get; set; } = new List<TblShopProductSchoolOrder>();
}

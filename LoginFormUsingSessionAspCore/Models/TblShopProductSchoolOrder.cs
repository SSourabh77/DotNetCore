using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblShopProductSchoolOrder
{
    public int SchoolOrderId { get; set; }

    public int? ShopProductInventoryid { get; set; }

    public decimal? OrderBySchool { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual TblShopProductInventory? ShopProductInventory { get; set; }
}

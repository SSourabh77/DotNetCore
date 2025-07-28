using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblMenuAccess
{
    public int MenuAccessId { get; set; }

    public string? MenuName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string Code { get; set; } = null!;

    public string? SubMenuAccess { get; set; }
}

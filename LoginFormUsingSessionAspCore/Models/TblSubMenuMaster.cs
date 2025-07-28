using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblSubMenuMaster
{
    public int Id { get; set; }

    public string? SubMenu { get; set; }

    public int? MenuId { get; set; }

    public virtual TblMenuMaster? Menu { get; set; }
}

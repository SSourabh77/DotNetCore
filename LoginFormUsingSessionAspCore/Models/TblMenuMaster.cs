using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblMenuMaster
{
    public int Id { get; set; }

    public string? Menu { get; set; }

    public virtual ICollection<TblSubMenuMaster> TblSubMenuMasters { get; set; } = new List<TblSubMenuMaster>();
}

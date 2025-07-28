using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblEquipment
{
    public int EquipmentId { get; set; }

    public string? EquipmentName { get; set; }

    public string? EquipmentDescription { get; set; }

    public string? EquipmentNumber { get; set; }

    public bool? IsArchive { get; set; }
}

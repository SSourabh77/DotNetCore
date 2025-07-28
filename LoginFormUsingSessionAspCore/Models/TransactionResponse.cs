using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TransactionResponse
{
    public int ResponseId { get; set; }

    public string? TransId { get; set; }

    public string? StudentCode { get; set; }

    public string? ResponseCode { get; set; }

    public string? MessageCode { get; set; }

    public string? Description { get; set; }

    public string? AuthCode { get; set; }

    public string? AvsResultCode { get; set; }

    public string? CvvResultCode { get; set; }

    public string? CavvResultCode { get; set; }

    public string? RefTransId { get; set; }

    public string? TransHash { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountType { get; set; }

    public string? NetworkTransId { get; set; }

    public string? ErrorCode { get; set; }

    public string? Errormessage { get; set; }

    public DateTime? ResponseTime { get; set; }

    public string? EmailId { get; set; }
}

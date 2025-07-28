using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblDocument
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? Description { get; set; }

    public DateOnly? DateOfUpload { get; set; }

    public int? DocumentTypeId { get; set; }

    public int? StudentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? OriginalDocumentName { get; set; }

    public string? DocumentType { get; set; }
}

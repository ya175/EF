using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}

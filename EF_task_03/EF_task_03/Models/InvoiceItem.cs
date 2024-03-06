using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class InvoiceItem
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public string ItemName { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal Tax { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;
}

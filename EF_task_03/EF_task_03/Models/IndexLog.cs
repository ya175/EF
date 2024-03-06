using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class IndexLog
{
    public int LogId { get; set; }

    public string EventData { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;
}

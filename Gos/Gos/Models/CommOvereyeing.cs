using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class CommOvereyeing
{
    public int ReweisOver { get; set; }

    public int Overeyeing { get; set; }

    public virtual Overeyingofpet OvereyeingNavigation { get; set; } = null!;

    public virtual Rewei ReweisOverNavigation { get; set; } = null!;
}

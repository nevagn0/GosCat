using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class TakeOvereyingofpet
{
    public int Id { get; set; }

    public int Animalid { get; set; }

    public int Peremoga { get; set; }

    public int Userid { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual Overeyingofpet PeremogaNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

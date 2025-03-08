using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Overeyingofpet
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<TakeOvereyingofpet> TakeOvereyingofpets { get; set; } = new List<TakeOvereyingofpet>();
}

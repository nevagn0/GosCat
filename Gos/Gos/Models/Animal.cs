using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Animal
{
    public int Id { get; set; }

    public int Age { get; set; }

    public int UserId { get; set; }

    public string Nameanimal { get; set; } = null!;

    public virtual Passport? Passport { get; set; }

    public virtual ICollection<Recod> Recods { get; set; } = new List<Recod>();

    public virtual ICollection<TakeOvereyingofpet> TakeOvereyingofpets { get; set; } = new List<TakeOvereyingofpet>();

    public virtual User User { get; set; } = null!;
}

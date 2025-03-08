using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Recod
{
    public int Id { get; set; }

    public int Vetclinid { get; set; }

    public int Userid { get; set; }

    public int Animalid { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual Vetclinic Vetclin { get; set; } = null!;
}

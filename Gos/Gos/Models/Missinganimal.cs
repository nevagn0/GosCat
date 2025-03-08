using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Missinganimal
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public int Animalid { get; set; }

    public virtual User User { get; set; } = null!;
}

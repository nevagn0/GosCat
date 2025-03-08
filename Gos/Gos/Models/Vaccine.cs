using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Vaccine
{
    public int Id { get; set; }

    public int Pssoprtid { get; set; }

    public virtual Passport Pssoprt { get; set; } = null!;
}

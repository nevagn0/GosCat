using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Passport
{
    public int Id { get; set; }

    public int Serea { get; set; }

    public int Number { get; set; }

    public int Animalid { get; set; }

    public virtual Animal IdNavigation { get; set; } = null!;

    public virtual ICollection<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
}

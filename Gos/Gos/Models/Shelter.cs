using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Shelter
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<Animalsinheltetr> Animalsinheltetrs { get; set; } = new List<Animalsinheltetr>();

    public virtual ICollection<Takeanimal> Takeanimals { get; set; } = new List<Takeanimal>();
}

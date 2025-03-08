using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Animalsinheltetr
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Idshelters { get; set; }

    public virtual Shelter IdsheltersNavigation { get; set; } = null!;

    public virtual ICollection<Takeanimal> Takeanimals { get; set; } = new List<Takeanimal>();
}

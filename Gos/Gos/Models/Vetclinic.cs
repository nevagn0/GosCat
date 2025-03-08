using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Vetclinic
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<Recod> Recods { get; set; } = new List<Recod>();

    public virtual ICollection<Rewei> Idcomms { get; set; } = new List<Rewei>();
}

using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Rewei
{
    public int Id { get; set; }

    public string Comm { get; set; } = null!;

    public int IdUser { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Vetclinic> Idvets { get; set; } = new List<Vetclinic>();
}

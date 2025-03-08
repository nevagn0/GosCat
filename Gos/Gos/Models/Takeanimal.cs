using System;
using System.Collections.Generic;

namespace Gos.Models;

public partial class Takeanimal
{
    public int Id { get; set; }

    public int Shelerid { get; set; }

    public int Aniimalsinsheltrsid { get; set; }

    public int Iduser { get; set; }

    public virtual Animalsinheltetr Aniimalsinsheltrs { get; set; } = null!;

    public virtual User IduserNavigation { get; set; } = null!;

    public virtual Shelter Sheler { get; set; } = null!;
}

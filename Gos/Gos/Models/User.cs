using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Gos.Models;

public partial class User
{
    public int Id { get; set; }
    [Display(Name = "Имя")]
    [Required(ErrorMessage = "Имя не может содержать больше 40 символов")]
    [StringLength(40, ErrorMessage = "Фамилия не может содержать больше 40 символов")]
    public string Firstname { get; set; } = null!;
    [Display(Name = "Фамилия")]
    [Required(ErrorMessage = "Фамилия не может содержать больше 40 символов")]
    [StringLength(40, ErrorMessage = "Фамилия не может содержать больше 40 символов")]
    public string Secondname { get; set; } = null!;
    [Display(Name = "Отчество")]
    [Required(ErrorMessage = "Отчество не может содержать больше 40 символов")]
    [StringLength(40, ErrorMessage = "Фамилия не может содержать больше 40 символов")]
    public string Therdname { get; set; } = null!;
    [Display(Name = "Телефон")]
    [Required(ErrorMessage = "Телефон не может содержать больше 40 символов")]
    [StringLength(40, ErrorMessage = "Фамилия не может содержать больше 40 символов")]
    public string Phone { get; set; } = null!;

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual ICollection<Missinganimal> Missinganimals { get; set; } = new List<Missinganimal>();

    public virtual ICollection<Recod> Recods { get; set; } = new List<Recod>();

    public virtual ICollection<Rewei> Reweis { get; set; } = new List<Rewei>();

    public virtual ICollection<TakeOvereyingofpet> TakeOvereyingofpets { get; set; } = new List<TakeOvereyingofpet>();

    public virtual ICollection<Takeanimal> Takeanimals { get; set; } = new List<Takeanimal>();
}

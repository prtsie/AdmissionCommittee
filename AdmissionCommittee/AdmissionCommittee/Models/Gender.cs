using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Models
{
    /// <summary>Пол для <see cref="Applicant"/></summary>
    public enum Gender
    {
        [Display(Name = "Неизвестен")]
        Unknown,
        [Display(Name = "Мужской")]
        Male,
        [Display(Name = "Женский")]
        Female,
        [Display(Name = "Боевой вертолёт")]
        AttackHelicopter,
        [Display(Name = "Пикачу")]
        Pikachu
    }
}

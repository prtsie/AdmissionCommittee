using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Models
{
    /// <summary>Пол для <see cref="Applicant"/></summary>
    public enum Gender
    {
        Unknown,
        Male,
        Female,
        AttackHelicopter,
        Pikachu
    }
}

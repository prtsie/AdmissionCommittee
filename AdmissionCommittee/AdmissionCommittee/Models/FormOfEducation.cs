using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Models
{
    /// <summary>Формы обучения для <see cref="Applicant"/></summary>
    public enum FormOfEducation
    {
        [Display(Name = "Очная")]
        Intramural,
        [Display(Name = "Заочная")]
        Extramural,
        [Display(Name = "Очно-заочная")]
        PartTime
    }
}

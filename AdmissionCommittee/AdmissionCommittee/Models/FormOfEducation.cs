using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Models
{
    /// <summary>Формы обучения для <see cref="Applicant"/></summary>
    public enum FormOfEducation
    {
        /// <summary>Очная форма обучения</summary>
        Intramural,
        /// <summary>Заочная форма обучения </summary>
        Extramural,
        /// <summary>Очно-заочная форма обучения</summary>
        PartTime
    }
}

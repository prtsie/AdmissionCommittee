using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Helpers
{
    /// <summary>Ограничения полей для <see cref="Models.Applicant"/></summary>
    internal static class ApplicantConstraints
    {
        public const int MaxLength = 50;
        public const int MinAge = 18;
        public const int MaxAge = 21;
    }
}

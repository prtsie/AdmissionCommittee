using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmissionCommittee.Helpers;

namespace AdmissionCommittee.Models
{
    /// <summary>
    /// Класс абитуриента
    /// </summary>
    internal sealed class Applicant
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        [Required]
        [MaxLength(ApplicantConstraints.MaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ApplicantConstraints.MaxLength)]
        public string Surname { get; set; }

        [MaxLength(ApplicantConstraints.MaxLength)]
        public string? Patronymic { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        ///<summary><inheritdoc cref="Models.FormOfEducation"/></summary>
        public FormOfEducation FormOfEducation { get; set; }

        ///<summary><inheritdoc cref="Models.Gender"/></summary>
        public Gender Gender { get; set; }

        [Range(0, 100)]
        public int MathScore { get; set; }

        [Range(0, 100)]
        public int RussianScore { get; set; }

        [Range(0, 100)]
        public int ITScore { get; set; }

        public int TotalScore => MathScore + RussianScore + ITScore;
    }
}

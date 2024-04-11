using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.Models
{
    /// <summary>
    /// Класс абитуриента
    /// </summary>
    internal sealed class Applicant
    {
        private const int MaxFieldLength = 50;

        [Required]
        [MaxLength(MaxFieldLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxFieldLength)]
        public string Surname { get; set; }

        [MaxLength(MaxFieldLength)]
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

        public string Initials => $"{Surname} {Name} {Patronymic ?? string.Empty}".Trim();
    }
}

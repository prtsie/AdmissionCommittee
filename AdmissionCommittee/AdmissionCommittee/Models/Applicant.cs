﻿using System;
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
    public sealed class Applicant : ICloneable
    {
        [Display(Name = "Id")]
        public Guid Id { get; private set; } = Guid.NewGuid();

        [Required]
        [MaxLength(ApplicantConstraints.MaxLength)]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Required]
        [MaxLength(ApplicantConstraints.MaxLength)]
        [Display(Name = "Фамилия")]
        public string? Surname { get; set; }

        [MaxLength(ApplicantConstraints.MaxLength)]
        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }

        [Required]
        [DateRange(ApplicantConstraints.MinAge, ApplicantConstraints.MaxAge)]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Форма обучения")]
        ///<summary><inheritdoc cref="Models.FormOfEducation"/></summary>
        public FormOfEducation FormOfEducation { get; set; }

        [Display(Name = "Пол")]
        ///<summary><inheritdoc cref="Models.Gender"/></summary>
        public Gender Gender { get; set; }

        [Range(0, 100)]
        [Display(Name = "Баллы по математике")]
        public int MathScore { get; set; }

        [Range(0, 100)]
        [Display(Name = "Баллы по русскому")]
        public int RussianScore { get; set; }

        [Range(0, 100)]
        [Display(Name = "Баллы по информатике")]
        public int ITScore { get; set; }

        [Display(Name = "Сумма баллов")]
        public int TotalScore => MathScore + RussianScore + ITScore;

        public object Clone() => MemberwiseClone();
    }
}

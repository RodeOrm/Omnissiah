using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Omnius.Domain.Abstract;

namespace Omnius.Domain.Entities
{
    [CustomerContactsAttribute]
    public class Customer
    {
        public int ID { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Длина имени должна не меньше 3 символов")]
        public string Name { get; set; }


        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="Длина фамилии должна не меньше 3 символов")]
        public string FamilyName { get; set; }


        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Не указано отчество")]
        public string PaternalName { get; set; }

        [Display(Name = "Полное имя в родительном падеже")]
        public string FirstCase { get; set; }

        [Display(Name = "Полное имя в дательном падеже")]
        public string SecondCase { get; set; }

        [Display(Name = "Пол")]
        public bool Sex { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Не указана дата рождения")]
        [CustomerDatesAttribute]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true, NullDisplayText= "No Date of Death is Selected")]
        [Display(Name = "Дата смерти")]
        [Obsolete]
        public DateTime DateOfDeath { get; set; }

        public IEnumerable<Contact> Contacts
        {
            get; set;
        }
        /*
        public IEnumerable<PersonalAccount> PersonalAccounts
        {
            get; set;
        }
        */
    }
}

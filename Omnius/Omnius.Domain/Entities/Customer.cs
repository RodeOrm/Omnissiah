using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Omnius.Domain.Entities
{
    public class Customer
    {

        public int ID { get; set; }


        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }


        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Не указана фамилия")]
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
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата смерти")]
        public DateTime DateOfDeath { get; set; }

        /*
        public List<Contact> Contacts { get; set; }

        public Customer()
        {

            Contacts = new List<Contact>();

        }
        */
    }
}

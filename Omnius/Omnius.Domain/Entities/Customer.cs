using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Omnius.Domain.Abstract;

namespace Omnius.Domain.Entities
{
    public class Customer 
    //Aggregate Root

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


        public List<Contact> contacts = new List<Contact>();

        public IEnumerable<Contact> Contacts
        {
            get; set;
        }

    }
}

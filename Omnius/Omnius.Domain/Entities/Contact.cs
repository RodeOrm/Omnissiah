using System.ComponentModel.DataAnnotations;

namespace Omnius.Domain.Entities
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int ContactTypeID { get; set; }

        //public ContactType ContactType { get; set; }

        [Display(Name = "Контактная информация")]
        [Required(ErrorMessage = "Укажите контактную информацию")]
        [ContactAttribute]
        public string Value { get; set; }

    }

    public class ContactType
    {
        public int ID { get; set; }
        public string Name {get; set;}
    }
}
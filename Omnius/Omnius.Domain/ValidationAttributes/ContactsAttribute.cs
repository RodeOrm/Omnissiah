using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Omnius.Domain.Abstract;
using System.Linq;

namespace Omnius.Domain.Entities
{
    public class ContactAttribute : ValidationAttribute
    {
        public ContactAttribute()
        {
        }            

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Contact contact = (Contact)validationContext.ObjectInstance;

            switch (contact.ContactTypeID)
            {
                case 1:
                    if (!IsPhoneNumber(contact.Value))
                    {
                        return new ValidationResult($"Введенное значение не телефонный номер");  //N.B. $ is short-hand for String.Format
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                case 2:
                    if (!IsEmail(contact.Value)) //TODO: сделать для адреса
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {

                        return ValidationResult.Success;
                    }
                case 3:
                    if (!IsEmail(contact.Value))
                    {
                        return new ValidationResult($"Введите корректный адрес электронной почты");
                    }
                    else
                    {

                        return ValidationResult.Success;
                    }
            }
            return ValidationResult.Success;
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^((\+7|7|8)+([0-9]){10})$").Success;
        }

        public static bool IsEmail(string email)
        {
            return Regex.Match(email, @"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$").Success;
        }

    }
}

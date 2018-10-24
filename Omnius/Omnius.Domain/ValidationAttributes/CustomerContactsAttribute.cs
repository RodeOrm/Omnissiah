using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Omnius.Domain.Entities;

namespace Omnius.Domain.Entities
{
    class CustomerContactsAttribute : ValidationAttribute
    {
        public CustomerContactsAttribute()
        {
            ErrorMessage = "Имя не должно совпадать с фамилией";
        }

        public override bool IsValid(object value)
        {
            Customer c = value as Customer;
            
            if (c.Name == c.FamilyName)
            {
                return false;
            }
            return true;
        }
    }
}

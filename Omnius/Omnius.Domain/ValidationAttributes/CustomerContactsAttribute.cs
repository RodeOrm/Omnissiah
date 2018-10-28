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
            ErrorMessage = "Дата смерти должна быть позже даты рождения";
        }

        public override bool IsValid(object value)
        {
            Customer c = value as Customer;
            
           if ((c.DateOfDeath >= c.DateOfBirth)||(c.DateOfDeath == null))
            {
                return true; 
            }
            return false;
        }
    }
}

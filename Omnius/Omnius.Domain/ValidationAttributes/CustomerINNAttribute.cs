using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Omnius.Domain.Abstract;
using System.Linq;
using System;

namespace Omnius.Domain.Entities
{
    class CustomerINNAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;

            if (!IsINNValid(customer.INN))
            {
                return new ValidationResult($"Некорректный ИНН");
            }
            else
            {
                return ValidationResult.Success;
            }
        }


        public static bool IsINNValid(string INNstring)
        {
            // является ли вообще числом
            try { Int64.Parse(INNstring); } catch { return false; }

            // проверка на 10 и 12 цифр
            if (INNstring.Length != 10 && INNstring.Length != 12) { return false; }

            // проверка по контрольным цифрам
            if (INNstring.Length == 10) // для юридического лица
            {
                int dgt10 = 0;
                try
                {
                    dgt10 = (((2 * Int32.Parse(INNstring.Substring(0, 1))
                        + 4 * Int32.Parse(INNstring.Substring(1, 1))
                        + 10 * Int32.Parse(INNstring.Substring(2, 1))
                        + 3 * Int32.Parse(INNstring.Substring(3, 1))
                        + 5 * Int32.Parse(INNstring.Substring(4, 1))
                        + 9 * Int32.Parse(INNstring.Substring(5, 1))
                        + 4 * Int32.Parse(INNstring.Substring(6, 1))
                        + 6 * Int32.Parse(INNstring.Substring(7, 1))
                        + 8 * Int32.Parse(INNstring.Substring(8, 1))) % 11) % 10);
                }
                catch { return false; }

                if (Int32.Parse(INNstring.Substring(9, 1)) == dgt10) { return true; }
                else { return false; }
            }
            else // для физического лица
            {
                int dgt11 = 0, dgt12 = 0;
                try
                {
                    dgt11 = (((
                        7 * Int32.Parse(INNstring.Substring(0, 1))
                        + 2 * Int32.Parse(INNstring.Substring(1, 1))
                        + 4 * Int32.Parse(INNstring.Substring(2, 1))
                        + 10 * Int32.Parse(INNstring.Substring(3, 1))
                        + 3 * Int32.Parse(INNstring.Substring(4, 1))
                        + 5 * Int32.Parse(INNstring.Substring(5, 1))
                        + 9 * Int32.Parse(INNstring.Substring(6, 1))
                        + 4 * Int32.Parse(INNstring.Substring(7, 1))
                        + 6 * Int32.Parse(INNstring.Substring(8, 1))
                        + 8 * Int32.Parse(INNstring.Substring(9, 1))) % 11) % 10);
                    dgt12 = (((
                        3 * Int32.Parse(INNstring.Substring(0, 1))
                        + 7 * Int32.Parse(INNstring.Substring(1, 1))
                        + 2 * Int32.Parse(INNstring.Substring(2, 1))
                        + 4 * Int32.Parse(INNstring.Substring(3, 1))
                        + 10 * Int32.Parse(INNstring.Substring(4, 1))
                        + 3 * Int32.Parse(INNstring.Substring(5, 1))
                        + 5 * Int32.Parse(INNstring.Substring(6, 1))
                        + 9 * Int32.Parse(INNstring.Substring(7, 1))
                        + 4 * Int32.Parse(INNstring.Substring(8, 1))
                        + 6 * Int32.Parse(INNstring.Substring(9, 1))
                        + 8 * Int32.Parse(INNstring.Substring(10, 1))) % 11) % 10);
                }
                catch { return false; }
                if (Int32.Parse(INNstring.Substring(10, 1)) == dgt11
                    && Int32.Parse(INNstring.Substring(11, 1)) == dgt12) { return true; }
                else { return false; }
            }
        }
    }
}

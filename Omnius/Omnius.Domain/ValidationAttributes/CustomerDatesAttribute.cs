using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Omnius.Domain.Abstract;
using System.Linq;
using System;

namespace Omnius.Domain.Entities
{
    public class CustomerDatesAttribute : ValidationAttribute
    {
        private int _years;
        private int _months;
        private int _days;
        
        public int Years
        {
            get { return _years; }
        }
        public int Months
        {
            get { return _months; }
        }
        public int Days
        {
            get { return _days; }
        }

        private string yearString;
        private string monthString;
        private string dayString;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;

            if (customer.DateOfBirth > DateTime.UtcNow.Date)
            {
                return new ValidationResult($"Дата рождения не может быть в будущем");  //N.B. $ is short-hand for String.Format
            }
            else if (customer.DateOfBirth < DateTime.Parse("01/01/1900"))
            {
                return new ValidationResult($"Потребитель должен быть рожден как минимум в XX веке");
            }
            else if (!IsAdult(customer.DateOfBirth, DateTime.UtcNow.Date, ref yearString, ref monthString, ref dayString))
            {
                return new ValidationResult($"Потребитель должен быть совершеннолетним. Его текущий возраст: {yearString}{monthString}{dayString}");
            }
            else
            {
                return ValidationResult.Success;
            }
        }

        public bool IsAdult(DateTime startDate, DateTime endDate, ref string yearString, ref string monthString, ref string dayString)
        {
            if (startDate > endDate)
            {
                DateTime tmpSwap = startDate;
                startDate = endDate;
                endDate = tmpSwap;
            }

            int startYear = startDate.Year;
            int startMonth = startDate.Month;
            int startDay = startDate.Day;
            
            int endYear = endDate.Year;
            int endMonth = endDate.Month;
            int endDay = endDate.Day;
            
            if (endDay < startDay)
            {
                DateTime previousMonth = endDate.AddMonths(-1);
                endDay += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
                
                endMonth -= 1;

                if (endMonth < 1)
                {
                    endMonth += 12;
                    endYear -= 1;
                }
            }

            if (endMonth < startMonth)
            {
                endMonth += 12;
                endYear -= 1;
            }
            
            _years = endYear - startYear;
            _months = endMonth - startMonth;
            _days = endDay - startDay;

            yearString = (Years == 0 ? string.Empty : string.Format("Годы: {0}, ", Years)).ToString();
            monthString = (Months == 0 ? string.Empty : string.Format("Месяцы: {0}, ", Months)).ToString();
            dayString = string.Format("Дни: {0}", Days);

            if (_years >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

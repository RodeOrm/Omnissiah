using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    class PersonalAccount
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int CustomerID { get; set; }
    }
}

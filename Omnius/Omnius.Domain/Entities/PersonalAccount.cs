﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    class PersonalAccount
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public Customer Customer { get; set; }

        public IEnumerable<AccountPoint> AccountPoints
        {
            get; set;
        }
    }

    class AccountPoint
    {
        public int ID { get; set; }

    }
}

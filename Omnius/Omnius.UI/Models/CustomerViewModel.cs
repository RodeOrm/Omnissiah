using System;
using System.Collections.Generic;
using System.Linq;
using Omnius.Domain.Entities;

namespace Omnius.UI.Models
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    public class NetworkItem
    {
        public int ID { get; set; }
        public int NetworkItemTypeID {get; set;}

    }

    public class NetworkItemType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

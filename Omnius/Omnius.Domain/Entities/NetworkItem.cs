using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    class NetworkItem
    {
        public int ID { get; set; }
        public int NetworkItemTypeID {get; set;}

    }

    class NetworkItemType
    {
        public int ID { get; set; }
    }
}

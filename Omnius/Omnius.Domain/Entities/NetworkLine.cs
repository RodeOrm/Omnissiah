using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    class NetworkLine
    {
        public int ID { get; set; }
        public int SourceItemID { get; set; }  // питающий элемент
        public int PoweredItemID { get; set; } // запитанный элемент

        public IEnumerable<NetworkEquipment> Equipments
        {
            get; set;
        }
    }
}

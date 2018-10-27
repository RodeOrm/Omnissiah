using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Omnius.Domain.Entities
{
    class NetworkObject
    {
        public int ID { get; set; }
        
    }

    class ConsumptionObject: NetworkObject
    {
        [Required]
        public string Address { get; set; }
    }

    class GenerationObject: NetworkObject
    {
        [Obsolete]
        public string Address { get; set; }
    }


}

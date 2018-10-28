using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Omnius.Domain.Entities
{
    public class NetworkObject
    {
        public int ID { get; set; }
        
    }

    public class ConsumptionObject: NetworkObject
    {
        [Required]
        public string Address { get; set; }
    }

    public class GenerationObject: NetworkObject
    {
        [Obsolete]
        public string Address { get; set; }
    }


}

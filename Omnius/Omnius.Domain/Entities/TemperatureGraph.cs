using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    public class TemperatureGraph
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<TemperatureGraphValue> TemperatureGraphValues
        {
            get; set;
        }
    }

    public class TemperatureGraphValue
    {
        public int TemperatureGraphID { get; set; }
        public int AirTemperature { get; set; }
        public decimal SupplyTemperature { get; set; }
        public decimal ReturnTemperature { get; set; }
    }
}

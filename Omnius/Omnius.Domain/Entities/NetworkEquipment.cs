using System;
using System.Collections.Generic;
using System.Text;

namespace Omnius.Domain.Entities
{
    public class NetworkEquipment
    {
        public int ID { get; set; }
        public int NetworkLineID;

        public NetworkEquipmentType EquipmentType { get; set; }
        public NetworkPipelineDiameter DirectPipeDiameter { get; set; }
        public NetworkPipelineDiameter ReturnPipeDiameter { get; set; }
        public NetworkPipelineLayingType LayingType { get; set; }
        public int YearOfLaying { get; set; }
        public TemperatureGraph TemperatureGraph { get; set; }
        public decimal PipeLength { get; set; } // Длина в метрах. Длина подающего трубопровда = Длина обратного трубопровода
        public decimal DirectPipelaneWeightedAverageTemp { get; set; }
        public decimal ReturnPipelaneWeightedAverageTemp { get; set; }
        public decimal DirectPipeHeatFluxDensity { get; set; }
        public decimal ReturnPipeHeatFluxDensity { get; set; }
    }

    //TODO: Выделить затем в отдельный класс Справочников
    public class NetworkEquipmentType
    /*
    Трубопровод отопления
    Трубопровод горячего водоснабжения
    Трубопровод общего назначения
     */
    {
        public int ID { get; set; }
        private string value;
    }

    public class NetworkPipelineDiameter
    // Условный диаметр трубопровода
    {
        public int ID { get; set; }
        private int value;
    }

    public class NetworkPipelineLayingType
    // Тип прокладки трубопровода
    {
        public int ID { get; set; }
        private string value;
    }
}

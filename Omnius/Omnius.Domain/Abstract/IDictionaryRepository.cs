using System.Collections.Generic;
using Omnius.Domain.Entities;

namespace Omnius.Domain.Abstract
{
    interface IDictionaryRepository
    {
        void CreateNetworkEquipmentType(NetworkEquipmentType EquipmentType);
        void CreatePipelineDiameter(NetworkPipelineDiameter item, NetworkEquipmentType distict);
        void CreateNetworkPipelineLayingType(NetworkPipelineLayingType line);

        void DeleteNetworkEquipmentType(int id);
        void DeletePipelineDiameter(int id);
        void DeleteNetworkPipelineLayingType(int id);

        NetworkEquipmentType GetNetworkEquipmentType(int id);
        NetworkPipelineDiameter GetPipelineDiameter(int id);
        NetworkPipelineLayingType GetNetworkPipelineLayingType(int id);

        IEnumerable<NetworkEquipmentType> GetNetworkEquipmentTypes();
        IEnumerable<NetworkPipelineDiameter> GetPipelineDiameter();
        IEnumerable<NetworkPipelineLayingType> GetNetworkPipelineLayingType();


        // IEnumerable<NetworkEquipmentType> GetNetworkEquipmentTypes(int pageNumber, int pageSize);

        void Update(NetworkEquipmentType EquipmentType);
        void Update(NetworkPipelineDiameter item);
        void Update(NetworkPipelineLayingType line);
    }
}

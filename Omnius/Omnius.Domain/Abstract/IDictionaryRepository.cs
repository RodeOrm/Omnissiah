using System.Collections.Generic;
using Omnius.Domain.Entities;

namespace Omnius.Domain.Abstract
{
    public interface IDictionaryRepository
    {
        //  Create
        void CreateNetworkEquipmentType(NetworkEquipmentType EquipmentType);
        void CreatePipelineDiameter(NetworkPipelineDiameter item, NetworkEquipmentType distict);
        void CreateNetworkPipelineLayingType(NetworkPipelineLayingType line);

        //Delete
        void DeleteNetworkEquipmentType(int id);
        void DeletePipelineDiameter(int id);
        void DeleteNetworkPipelineLayingType(int id);

        //Get
        NetworkEquipmentType GetNetworkEquipmentType(int id);
        NetworkPipelineDiameter GetPipelineDiameter(int id);
        NetworkPipelineLayingType GetNetworkPipelineLayingType(int id);

        //Get all
        IEnumerable<NetworkEquipmentType> GetNetworkEquipmentTypes();
        IEnumerable<NetworkPipelineDiameter> GetPipelineDiameter();
        IEnumerable<NetworkPipelineLayingType> GetNetworkPipelineLayingType();


        // IEnumerable<NetworkEquipmentType> GetNetworkEquipmentTypes(int pageNumber, int pageSize);

        // Update
       void Update(NetworkEquipmentType EquipmentType);
       void Update(NetworkPipelineDiameter item);
       void Update(NetworkPipelineLayingType line);
    }
}

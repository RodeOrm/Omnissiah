using System.Collections.Generic;
using Omnius.Domain.Entities;

namespace Omnius.Domain.Abstract
{
    public interface INetworkRepository
    {
        // Create
        void CreateNetworkDistrict(NetworkDistrict district);
        void CreateNetworkItem(NetworkItem item, NetworkDistrict distict);
        void CreateNetworkLine(NetworkLine line, NetworkItem parentItem, NetworkItem childItem);

        // Delete
        void DeleteNetworkDistrict(int id);
        void DeleteNetworkItem(int id);
        void DeleteNetworkLine(int id);

        //Get
        NetworkDistrict GetNetworkDistrict(int id);
        NetworkItem GetNetworkItem(int id);
        NetworkLine GetNetworkLine(int id);

        //Get all
        IEnumerable<NetworkDistrict> GetNetworkDistricts();
        IEnumerable<NetworkItem> GetNetworkItem();
        IEnumerable<NetworkLine> GetNetworkLine();


        // IEnumerable<NetworkDistrict> GetNetworkDistricts(int pageNumber, int pageSize);

        // Update
        void Update(NetworkDistrict district);
        void Update(NetworkItem item);
        void Update(NetworkLine line);
    }
}

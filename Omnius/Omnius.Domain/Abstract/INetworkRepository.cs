using System.Collections.Generic;
using Omnius.Domain.Entities;

namespace Omnius.Domain.Abstract
{
    interface INetworkRepository
    {
        void CreateNetworkDistrict(NetworkDistrict district);
        void CreateNetworkItem(NetworkItem item, NetworkDistrict distict);
        void CreateNetworkLine(NetworkLine line, NetworkItem parentItem, NetworkItem childItem);

        void DeleteNetworkDistrict(int id);
        void DeleteNetworkItem(int id);
        void DeleteNetworkLine(int id);

        NetworkDistrict GetNetworkDistrict(int id);
        NetworkItem GetNetworkItem(int id);
        NetworkLine GetNetworkLine(int id);

        IEnumerable<NetworkDistrict> GetNetworkDistricts();
        IEnumerable<NetworkItem> GetNetworkItem();
        IEnumerable<NetworkLine> GetNetworkLine();


        // IEnumerable<NetworkDistrict> GetNetworkDistricts(int pageNumber, int pageSize);

        void Update(NetworkDistrict district);
        void Update(NetworkItem item);
        void Update(NetworkLine line);
    }
}

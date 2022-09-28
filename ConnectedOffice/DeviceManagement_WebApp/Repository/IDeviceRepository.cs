using DeviceManagement_WebApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Zone> GetZones();
    }
}

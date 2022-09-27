using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class DeviceRepository : GenericRepository<Device> , IDeviceRepository
{
	public DeviceRepository(ConnectedOfficeContext context) : base(context)
	{
	}

	public Device GetById(Guid id)
	{
		throw new NotImplementedException();
	}
}

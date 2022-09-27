using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class DeviceRepository
{
	protected readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
	
	//GET All Devices
	public IEnumerable<Device> GetAll()
	{
		return _context.Device.ToList();
	}
}

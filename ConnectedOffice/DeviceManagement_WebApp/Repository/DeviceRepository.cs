using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class DeviceRepository
{
	protected readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
	
	public DeviceRepository()
	{

	}
	
	
	//GET All Devices
	public IEnumerable<Device> GetAll()
	{
		return _context.Device.ToList();
	}
}

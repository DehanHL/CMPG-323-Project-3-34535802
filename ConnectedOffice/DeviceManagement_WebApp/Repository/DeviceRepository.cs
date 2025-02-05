﻿using DeviceManagement_WebApp.Data;
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
	public IEnumerable<Category> GetCategories()
	{
		return _context.Category.ToList();
	}
	public IEnumerable<Zone> GetZones()
	{
		return _context.Zone.ToList();
	}
}

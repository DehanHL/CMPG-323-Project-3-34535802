using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

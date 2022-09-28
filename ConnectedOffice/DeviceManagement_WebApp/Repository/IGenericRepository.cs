using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid? id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        //Check if id already exists
        bool Exists(Guid? id);
        //Appen Changes
        void Save();
        //Sets/Updates
        void Update(T entity);
        //Already gets new GUID as param so just creates
        void Create(T entity);
        //Deletes existing
        void Delete(T entity);
        //Edits existing record
        void Edit(T entity);
    }
}

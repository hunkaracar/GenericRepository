using GenericRepository.Entities.Abstract;
using GenericRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T : class,IEntity, new()
    {

        //CRUD

        void Create(T entity); //(C)reate
        List<T> GetAll();        //(R)ead

        T Get();
        void Update(T entity);  //(U)pdate

        void Delete(int entity); //(D)elete
    }
}

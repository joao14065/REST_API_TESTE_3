using REST_API_TESTE_3.Model.Base;
using System.Collections.Generic;

namespace REST_API_TESTE_3.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long Id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long Id);
        bool Exist(long id);

    }
}

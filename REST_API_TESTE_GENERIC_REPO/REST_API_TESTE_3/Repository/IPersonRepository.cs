using REST_API_TESTE_3.Model;
using System.Collections.Generic;

namespace REST_API_TESTE_3.Repository
{
    // Serviço do objeto 'Person'
    // Tal serviço realiza todas as possíveis ações que o objeto pode realizar
    // Aconselha-se a criar um serviço padrão p/ todos os objetos utilizados em soluções futuras
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
        bool Exist(long id);

    }
}

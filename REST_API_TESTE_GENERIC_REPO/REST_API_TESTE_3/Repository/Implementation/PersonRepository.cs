using REST_API_TESTE_3.Model;
using REST_API_TESTE_3.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace REST_API_TESTE_3.Repository.Implementation
{
    // Serviço de implementação no banco de dados p/ o objeto 'Person'
    // Para cada objeto existente na solução, será necessário um serviço para implementação
    // Aconselha-se a criar um serviço de implementação padrão p/ todos os objetos utilizados em soluções 
    public class PersonRepository : IPersonRepository
    {

        // Parametro que conecta o código ao banco de dados
        private readonly PostgreSQLContext _context;

        public PersonRepository(PostgreSQLContext context)
        {
            _context = context;
        }

        // Metodo responsável por criar uma nova pessoa
        // Se tivéssemos um banco de dados esse seria o
        // momento de persistir os dados
        public Person Create(Person person)
        {

            try
            {
                // Adiciona o objeto 'person' no banco e salva as alterações
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long Id)
        {
            var result = _context.Person.SingleOrDefault(p => p.Id == Id);
            try
            {
                if (result != null) _context.Person.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método responsável por retornar todas as pessoas
        // mais uma vez essas informações são mocks
        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }

        // Método responsável por retornar uma pessoa
        // como não acessamos nenhuma base de dados
        // estamos retornando um mock
        public Person FindById(long Id)
        {
            return _context.Person.SingleOrDefault(p => p.Id.Equals(Id));
        }

        // Método responsável por atualizar uma pessoa
        // por ser mock retornamos a mesma informação passada
        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return null;

            var result = _context.Person.SingleOrDefault(p => p.Id == person.Id);
            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public bool Exist(long id)
        {
            return _context.Person.Any(p => p.Id == id);
        }
    }
}

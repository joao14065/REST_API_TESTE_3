using REST_API_TESTE_3.Data.Converters;
using REST_API_TESTE_3.Data.VO;
using REST_API_TESTE_3.Model;
using REST_API_TESTE_3.Repository;
using REST_API_TESTE_3.Repository.Generic;
using System.Collections.Generic;

namespace REST_API_TESTE_3.Business.Implementation
{
    /// <summary>
    ///  Classe <c>IPersonBusiness</c>.
    ///  Realiza as ações CRUD no objeto PersonVO.
    /// <list type="bullet">
    /// <item>
    /// <term>Create</term>
    /// <description>Cria um objeto.</description>
    /// </item>
    /// <item>
    /// <term>FindById</term>
    /// <description>Pesquisa um objeto por Id.</description>
    /// </item>
    /// <item>
    /// <term>FindAll</term>
    /// <description>Encontra todos os objetos.</description>
    /// </item>
    /// <item>
    /// <term>Update</term>
    /// <description>Atualiza um objeto.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Deleta um objeto.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// Aconselha-se a criar um serviço padrão p/ todos os objetos utilizados em soluções futuras.
    /// </remarks>
    public class PersonBusiness : IPersonBusiness
    {


        /// <summary>
        /// Campo para instanciar o repositorio.
        /// </summary>
        private IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        /// <summary>
        /// Método que recebe um parâmetro para instanciar o repositorio. 
        /// </summary>
        /// <returns>
        /// Uma instância do repositório.
        /// </returns>
        /// <param name="repository">parâmetro de instância.</param>
        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        /// <summary>
        /// Metodo responsável por criar uma nova pessoa.
        /// </summary>
        /// <param name="PersonVO">Objeto.</param>
        /// <returns></returns>
        public PersonVO Create(PersonVO Person)
        {
            var PersonEntity = _converter.Parse(Person);
            PersonEntity = _repository.Create(PersonEntity);
            return _converter.Parse(PersonEntity);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        // Método responsável por retornar todas as pessoas
        // mais uma vez essas informações são mocks
        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        // Método responsável por retornar uma pessoa
        // como não acessamos nenhuma base de dados
        // estamos retornando um mock
        public PersonVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        // Método responsável por atualizar uma pessoa
        // por ser mock retornamos a mesma informação passada
        public PersonVO Update(PersonVO Person)
        {
            var PersonEntity = _converter.Parse(Person);
            PersonEntity = _repository.Update(PersonEntity);
            return _converter.Parse(PersonEntity);
        }
    }
}

﻿using REST_API_TESTE_3.Model;
using REST_API_TESTE_3.Repository;
using REST_API_TESTE_3.Repository.Generic;
using System.Collections.Generic;

namespace REST_API_TESTE_3.Business.Implementation
{
    /// <summary>
    ///  Classe <c>IPersonBusiness</c>.
    ///  Realiza as ações CRUD no objeto Person.
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
    public class BookBusiness : IBookBusiness
    {


        /// <summary>
        /// Campo para instanciar o repositorio.
        /// </summary>
        private IRepository<Book> _repository;

        /// <summary>
        /// Método que recebe um parâmetro para instanciar o repositorio. 
        /// </summary>
        /// <returns>
        /// Uma instância do repositório.
        /// </returns>
        /// <param name="repository">parâmetro de instância.</param>
        public BookBusiness(IRepository<Book> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Metodo responsável por criar uma nova pessoa.
        /// </summary>
        /// <param name="person">Objeto.</param>
        /// <returns></returns>
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        // Método responsável por retornar todas as pessoas
        // mais uma vez essas informações são mocks
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        // Método responsável por retornar uma pessoa
        // como não acessamos nenhuma base de dados
        // estamos retornando um mock
        public Book FindById(long Id)
        {
            return _repository.FindById(Id);
        }

        // Método responsável por atualizar uma pessoa
        // por ser mock retornamos a mesma informação passada
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}

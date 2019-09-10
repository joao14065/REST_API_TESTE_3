﻿using REST_API_TESTE_3.Model;
using System.Collections.Generic;

namespace REST_API_TESTE_3.Business
{
    /// <summary>
    ///  Interface <c>IPersonBusiness</c>.
    ///  Inicializa todas as ações que a classe referenciada a ele executa.
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
    public interface IBookBusiness
    {
        /// <summary>
        /// Recebe um objeto <paramref name="person"/> e o cria na tabela.
        /// </summary>
        /// <param name="person">O objeto Person</param>
        Person Create(Person person);
        /// <summary>
        /// Recebe um long <paramref name="Id"/> e envia o objeto referente.
        /// </summary>
        /// <param name="Id">um inteiro 64bit.</param>
        /// <returns>
        /// O objeto referente.
        /// </returns>
        Person FindById(long Id);
        /// <summary>
        /// Envia todos os objetos.
        /// </summary>
        /// <returns>
        /// Todos os objetos da tabela.
        /// </returns>
        List<Person> FindAll();
        /// <summary>
        /// Recebe um objeto modificado <paramref name="person"/> e o atualiza na tabela.
        /// </summary>
        /// <param name="person">O objeto Person</param>
        Person Update(Person person);
        /// <summary>
        /// Recebe um long <paramref name="Id"/> e deleta o objeto referente da tabela.
        /// </summary>
        /// <param name="Id">um inteiro 64bit.</param>
        void Delete(long Id);

    }
}


using System.Collections.Generic;

namespace Orland.Dio.Series
{
    /// <summary>
    /// Um repositório de <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Classe a ser informada para definir o tipo do Repositorio.
    /// </typeparam>
    interface IRepositorio<T>
    {
        /// <summary>
        /// Lista todas as entidades do repositório.
        /// </summary>
        /// <returns>Retorna todas as entidades do repositório.</returns>
        List<T> Listar();
        /// <summary>
        /// Obtem uma entidade do repositório pelo Id.
        /// </summary>
        /// <param name="id">Id da entidade a ser obtida.</param>
        /// <returns>Retorna a entidade do repositorio com o <paramref name="id"/> informado.</returns>
        T ObterPorId(int id);
        /// <summary>
        /// Insere um nova entidade no repositório.
        /// </summary>
        /// <param name="entidade">entidade a ser incluída no repositório.</param>
        void Inserir(T entidade);
        /// <summary>
        /// Exlcui uma entidade do repositório.
        /// </summary>
        /// <param name="id">Id do elemento a ser excluído.</param>
        void Excluir(int id);
        /// <summary>
        /// Atualiza uma entidade do repositório.
        /// </summary>
        /// <param name="id">Id do elemento a ser atualizado.</param>
        /// <param name="entidade">Entidade com os dados a serem incluídos no lugar dos dados da entidade com o <paramref name="id"/> informado.</param>
        void Atualizar(int id, T entidade);
        /// <summary>
        /// Obtém o próximo Id do repositório.
        /// </summary>
        /// <returns>O valor do próximo Id do repositório.</returns>
        int ObterProximoId();
    }
}

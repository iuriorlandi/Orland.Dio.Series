using System.Collections.Generic;
using System.Linq;

namespace Orland.Dio.Series
{
    /// <summary>
    /// Implementação de umm <see cref="IRepositorio{T}"/> de <see cref="Serie"/>.
    /// </summary>
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaDeSeries { get; set; }

        public void Atualizar(int id, Serie entidade)
        {
            ListaDeSeries[id] = entidade;
        }

        public void Excluir(int id)
        {
            ListaDeSeries[id].Excluir();
        }

        public void Inserir(Serie entidade)
        {
            ListaDeSeries.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return ListaDeSeries;
        }

        public Serie ObterPorId(int id)
        {
            return ListaDeSeries[id]
        }

        public int ObterProximoId()
        {
            return ListaDeSeries.Count();
        }
    }
}

using System;

namespace Orland.Dio.Series
{
    /// <summary>
    /// Representa uma série de televisão.
    /// </summary>
    public class Serie : EntidadeBase
    {
        /// <summary>
        /// Gênero da série.
        /// </summary>
        public Genero Genero { get; set; }
        /// <summary>
        /// Título da série.
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Descrição da série.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Ano de lançamento da série.
        /// </summary>
        public int Ano { get; set; }
        private bool Excluido { get; set; } = false;

        /// <summary>
        /// Consutrutor que cria uma <see cref="Serie"/> definindo os valores de <see cref="EntidadeBase.Id"/>, <see cref="Genero"/>, <br/>
        /// <see cref="Titulo"/>, <see cref="Descricao"/> e <see cref="Ano"/>.
        /// </summary>
        /// <param name="id">Valor a ser atribuido em <see cref="EntidadeBase.Id"/>.</param>
        /// <param name="genero">Valor a ser atribuido em <see cref="Genero"/>.</param>
        /// <param name="titulo">Valor a ser atribuido em <see cref="Titulo"/></param>
        /// <param name="descricao">Valor a ser atribuido em <see cref="Descricao"/></param>
        /// <param name="ano">Valor a ser atribuido em <see cref="Ano"/></param>
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            (Id, Genero, Titulo, Descricao, Ano) = (id, genero, titulo, descricao, ano);
        }

        /// <summary>
        /// Definie uma <see cref="Serie"/> como excluída, atribuíndo <see langword="true"/> ao campo <see cref="Excluido"/>.
        /// </summary>
        internal void Excluir()
        {
            Excluido = true;
        }

        public override string ToString()
        {
            if (Excluido)
                return "...";

            return $"{Titulo} - {Ano}{Environment.NewLine}" +
                   $"{Genero} - {Descricao}";
        }
    }
}

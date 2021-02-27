using System;

namespace Orland.Dio.Series
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            (Id, Genero, Titulo, Descricao, Ano) = (id, genero, titulo, descricao, ano);
        }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}{Environment.NewLine}" +
                   $"{Genero} - {Descricao}";
        }
    }
}

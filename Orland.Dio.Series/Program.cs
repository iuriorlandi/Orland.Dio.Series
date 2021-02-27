using System;

namespace Orland.Dio.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var serie = new Serie(1, Genero.Acao, "Sherlock", "Série insipirada nos livros de Arthur Conan Doyle", 2010);

            Console.WriteLine(serie);
        }
    }
}

using System;

namespace Orland.Dio.Series
{
    class Program
    {
        static IRepositorio<Serie> Repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            var sair = false;
            while (!sair)
            {
                int opcao = ObterOpcao();

                switch (opcao)
                {
                    case 1:
                        ListarSeries();
                        break;
                    case 2:
                        //VisualizarSerie();
                        break;
                    case 3:
                        CadastrarSerie();
                        break;
                    case 4:
                        //ExcluirSerie();
                        break;
                    case 5:
                        //EditarSerie();
                        break;
                    case 6:
                        sair = true;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Realiza edição em uma série cadastrada.
        /// </summary>
        private static void EditarSerie()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui uma série.
        /// </summary>
        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastra uma nova série.
        /// </summary>
        private static void CadastrarSerie()
        {
            var titulo = InicializarCampoString(nameof(Serie.Titulo));
            var descricao = InicializarCampoString(nameof(Serie.Descricao));

            Console.Clear();

            bool entradaValida = false;
            short genero = 0;
            while (!entradaValida)
            {
                var arrayDeGeneros = Enum.GetValues(typeof(Genero));

                Console.WriteLine("Digite o gênero dentre as seguintes opções:");
                foreach (short i in arrayDeGeneros)
                {
                    Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
                }
                string entradaGenero = Console.ReadLine();

                if (short.TryParse(entradaGenero, out genero) && genero <= arrayDeGeneros.Length)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine($"{nameof(Serie.Genero)} inválidoo!");
                    Console.WriteLine();
                }

            }
            
            Console.Clear();

            entradaValida = false;
            int ano = 0;

            while (!entradaValida)
            {
                Console.WriteLine("Digite o ano de lançamento:");
                string entradaAno = Console.ReadLine();


                if (int.TryParse(entradaAno, out ano))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine($"{nameof(Serie.Ano)} inválido");
                    Console.WriteLine();
                }
            }

            Repositorio.Inserir(new Serie(Repositorio.ObterProximoId(), (Genero)genero, titulo, descricao, ano));
        }

        /// <summary>
        /// Obtém uma entrada do usuário para um campo string.
        /// </summary>
        /// <param name="campo">Nome do campo a ser obtido.</param>
        /// <returns>Retorna o valor informado pelo usuário.</returns>
        private static string InicializarCampoString(string campo)
        {
            Console.Clear();
            Console.WriteLine("--Cadastro de Série--");
            Console.WriteLine();

            Console.WriteLine($"{campo} da série:");
            return Console.ReadLine();
        }

        /// <summary>
        /// Exibe uma série específica.
        /// </summary>
        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista as séries cadastradas.
        /// </summary>
        private static void ListarSeries()
        {
            Console.Clear();

            var lista = Repositorio.Listar();

            foreach (var serie in lista)
            {
                Console.WriteLine($"{serie.Id} {Environment.NewLine}{serie.ToString()}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Obtém a opção do usuário.
        /// </summary>
        /// <returns>O valor da opção escolhida pelo usuário.</returns>
        private static int ObterOpcao()
        {
            Console.Clear();
            Console.WriteLine("---Orland.DIO.Series---");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine();

            Console.WriteLine("1 - Listar Séries.");
            Console.WriteLine("2 - Visualizar Série.");
            Console.WriteLine("3 - Cadastrar Série.");
            Console.WriteLine("4 - Excluir Série.");
            Console.WriteLine("5 - Editar Série.");
            Console.WriteLine("6 - Sair.");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
    }
}

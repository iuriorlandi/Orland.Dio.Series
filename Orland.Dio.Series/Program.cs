using System;

namespace Orland.Dio.Series
{
    class Program
    {
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
                        VisualizarSerie();
                        break;
                    case 3:
                        CadastrarSerie();
                        break;
                    case 4:
                        ExcluirSerie();
                        break;
                    case 5:
                        EditarSerie();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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

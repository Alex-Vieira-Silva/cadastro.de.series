using System;
using Cadastro.De.Series;
using Cadastro.De.Series.Lista;

namespace cadastro.de.series
{
    class Program
    {
        private static object indice_Serie;
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {

                string escolherusuario = OpcaoUsuario();

                while (escolherusuario.ToUpper() != "X")
                {
                    switch (escolherusuario)
                    {
                        case "1":
                            ListarSeries();
                            break;

                        case "2":
                            InserirSerie();
                            break;

                        case "3":
                            AtualizarSerie();
                            break;

                        case "4":
                            ExcluirSerie();
                            break;

                        case "5":
                            VisualizarSerie();
                            break;

                        case "C":
                            Console.Clear();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                Console.WriteLine("Obrigado por utilizar os nossos serviços.");
                Console.ReadLine();

             static string OpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("-------------Lg Series - Cadastro de Series--------------");
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada!!!");

                Console.WriteLine("1 - Lista series");
                Console.WriteLine("2 - Inserir um nova serie");
                Console.WriteLine("3 - Atualizar serie");
                Console.WriteLine("4 - Excluir serie");
                Console.WriteLine("5 - Vizualizar serie");
                Console.WriteLine("6 - Limpar Tela");
                Console.WriteLine("x - sair");

                string obeterusuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return obeterusuario;

            }

            static void InserirSerie()
            { 

                foreach (int i in Genero.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
                }

                Console.Write("Digite o gênero entre as opções acima: ");
		
                int entrada_Genero = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título da Série: ");
                string entrada_Titulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início da Série: ");
                int entrada_Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Série: ");
                string entrada_Descricao = Console.ReadLine();

                Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                            genero: (Genero)entrada_Genero,
                                            titulo: entrada_Titulo,
                                            ano: entrada_Ano,
                                            descricao: entrada_Descricao);

                repositorio.Enserir(novaSerie);
                
            }

            static void AtualizarSerie()
            {

                Console.Write("Digite o id da série: ");
                int indice_Serie = int.Parse(Console.ReadLine());

                foreach (int i in Genero.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entrada_Genero = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título da Série: ");
                string entrada_Titulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início da Série: ");
                int entrada_Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Série: ");
                string entrada_Descricao = Console.ReadLine();

                Serie atualiza_Serie = new Serie(id: indice_Serie,
                                            genero: (Genero)entrada_Genero,
                                            titulo: entrada_Titulo,
                                            descricao: entrada_Descricao,
                                            ano: entrada_Ano
    
                                            );

                repositorio.Atualizar(indice_Serie, atualiza_Serie);
            }

             static void ExcluirSerie()
            {
                Console.Write("Digite o id da série: ");
                int indice_Serie = int.Parse(Console.ReadLine());

                repositorio.Excluir(indice_Serie);
            }

             static void VisualizarSerie()
            {
                Console.Write("Digite o id da serie: ");
                int indiceSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.getId(indice_Serie);

                Console.WriteLine(serie);
            }

            static void ListarSeries()
            {
                Console.WriteLine("Listar séries");

                var lista = repositorio.Lista();

                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada.");
                    return;
                }

                foreach (var serie in lista)
                {
                    var excluido = serie.getExcluido();

                    Console.WriteLine("Id {0}: - {1}  {2}", serie.getId(), serie.getTitulo(), (excluido ? "*Excluído*" : ""));
                }
            }
        }
    }

    }

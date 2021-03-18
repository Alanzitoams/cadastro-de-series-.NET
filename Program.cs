using System;

namespace LAN.series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.toUpper() != "x")
            {
               switch (opcaoUsuario)
               {
                   case "1";
                        listaSeries();
                        break;
                   case "2";
                        InserirSerie();
                        break;
                   case "3";
                        AtualizarSerie();
                        break;
                   case "4";
                        ExcluirSerie();
                        break;
                   case "5";
                        VisualizarSerie();
                        break;
                   case "c";]
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
               } 
                opcaoUsuario = ObterOpcaoUsuario(); 
            }
            console.WriteLine("Obrigado por utilizar nossos serviços");
            console.ReadLine();
        }
        private static void listaSeries()
        {
            console.WriteLine("listaSeries")
            var lista = repositorio.Lista();
            if (lista.count==0)
            {
               console.WriteLine("Nenhuma serie cadastrada") 
               return
            }
            foreach (var serie in lista)
            {
                console.WriteLine("#Id {0} - {1}", serie.RetornaId(),retornaTitulo())
            }
        }
        public void  InserirSerie()
        {
            console.WriteLine(" Inserir nova serie ");
            foreach (int i  in Enum.GetName(typeOF(Genero)))
            {
               console.WriteLine("{0}-{1}", i, Enum.GetValues(typeof(Genero),i));
            }
            console.WriteLine("Digite o genero entre as opcoes acima");
            int entradaGenero = int.Parse(console.ReadLine());

            console.WriteLine("Digite o titulo da serie");
            string entradaTitulo = console.ReadLine();

            console.WriteLine("Digite o ano de inicio da serie");
            int entradaAno = int.Parse(console.ReadLine());

            console.WriteLine("Digite a descriçao daserie:");
            string entradaDescricao = console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio,ProximoId(),
                                        genero: Genero,entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
        repositorio.Insere(novaSerie);

        }

        private static string ObterOpcaoUsuario()
        {
            console.WriteLine();
            console.WriteLine("1- LAN series ao seu dispor!!!");
            console.WriteLine("2- Inserir nova serie");
            console.WriteLine("3- Atualizar serie");
            console.WriteLine("4- Excluir serie");
            console.WriteLine("5- Visualizar serie");
            console.WriteLine("c- Limpar tela");
            console.WriteLine("x- Sair");
            console.WriteLine()

            string OpcaoUsuario = console.ReadLine().ToUpper();
            console.WriteLine();
            return OpcaoUsuario;

        }
    }
}

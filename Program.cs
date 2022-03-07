using System;

namespace App_filmes.Class;

public class Program{
    static SeriesRepositorio repositorio = new SeriesRepositorio();
    public static void Main(string[] args){

        int Opcao;

        while(true){

        Console.WriteLine();
        Console.WriteLine("BEM VINDO AO NOSSO CATALOGO DE SERIES!");
        menu:
        Console.WriteLine("Selecione uma opção: ");
        Console.WriteLine();

        Console.WriteLine("1- Listar séries");
        Console.WriteLine("2- Inserir nova série em seu pacote");
        Console.WriteLine("3- Atualizar série");
        Console.WriteLine("4- Visualizar série");
        Console.WriteLine("5- Limpar tela");
        Console.WriteLine("6- Sair");
        Console.WriteLine();
        #nullable disable
        Opcao = int.Parse(Console.ReadLine());


            switch (Opcao)
            {
                case 1:
                    Console.Clear();
                    ListarSeries();
                break;
                case 2:
                    Console.Clear();
                    InserirSerie();
                break;
                case 3:
                    Console.Clear();
                    AtualizarSerie();
                break;
                case 4:
                    Console.Clear();
                    Visualiza();
                break;
                case 5:
                    Console.Clear();
                break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Programação encerrada!");
                    Environment.Exit(0);
                break;
                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida!");
                    goto menu;
                break;
            }   
        }

         void ListarSeries(){
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Nenhuma Série cadastrada!");
            }
            foreach(var serie in lista){

                var excluido = serie.retornaIdExcluido();
                Console.WriteLine($"ID {serie.retornaId}: {serie.retornaTitulo}"+ (excluido ? "Excluido" : "Catalogado"));

            }
        }

        void InserirSerie(){
            Console.WriteLine("Insira uma nova serie.");

            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1} ", i , Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o genero: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie: ");
            String entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição da serie: ");
            String entradaDescricao = Console.ReadLine();
            
            Console.WriteLine("Digite o ano de lançamento da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Series novaSerie = new Series(id: repositorio.Proximo(), 
                                            genero:(Genero)entradaGenero, 
                                            titulo:entradaTitulo, 
                                            ano:entradaAno, 
                                            descricao:entradaDescricao);
    
            repositorio.Insere(novaSerie);
    }

        void AtualizarSerie(){

            Console.WriteLine("Digite o id da sua série: ");
            int indice = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i ,Enum.GetNames(typeof(Genero)), i);
            }

            Console.WriteLine("Digite o genero: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie: ");
            String entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição da serie: ");
            String entradaDescricao = Console.ReadLine();
            
            Console.WriteLine("Digite o ano de lançamento da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Series atualizaSerie = new Series(id: indice, 
                                            genero:(Genero)entradaGenero, 
                                            titulo:entradaTitulo, 
                                            ano:entradaAno, 
                                            descricao:entradaDescricao);
    
            repositorio.Atualiza(indice, atualizaSerie);
        }

        void Visualiza(){
            Console.WriteLine("Digite o id da série que você queira consultar");
            int indice = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indice);

            Console.WriteLine(serie);
        }

        void Exclui(){
            Console.WriteLine("Digite o id da série que queira excluir");
            int indice = int.Parse(Console.ReadLine());

            repositorio.Exclui(indice);
        }     
}

}
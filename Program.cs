using System;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabela: ");
            
            ConsoleKeyInfo a;
            Campeonato campeonato = new Campeonato();

            do {
            Console.Write("Digite sua opção: ");
            a = Console.ReadKey()   ;

            if (a.Key == ConsoleKey.D1) {
                System.Console.WriteLine("Adiciona uma nova equipe");
                System.Console.WriteLine("Digite o nome da equipe:");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Digite a pontuação:");
                string pontuacao = Console.ReadLine();
                campeonato.equipes.Add(new Equipe(nome, Int32.Parse(pontuacao)));
            }
            } while (a.Key != ConsoleKey.D2);

            System.Console.WriteLine("Listando o resultado: ");
            campeonato.ordenaPontuacao();
            campeonato.resultado();
            System.Console.WriteLine("resultado: ");
            campeonato.rebaixados();
            campeonato.Campeão();

        }
    }
}

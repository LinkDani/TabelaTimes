using System;
using System.Collections;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipe[] time = new Equipe[3];

            time[0] = new Equipe();
            Console.WriteLine("Escreva o nome do time: ");
            time[0].nome = Console.ReadLine();
            Console.WriteLine("Escreva a atual pontuação do time: ");
            time[0].pontuacao = Convert.ToInt32(Console.ReadLine());
            
            time[1] = new Equipe();
            Console.WriteLine("Escreva o próximo do time: ");
            time[1].nome = Console.ReadLine();
            Console.WriteLine("Escreva a atual pontuação do time: ");
            time[1].pontuacao = Convert.ToInt32(Console.ReadLine());

            time[2] = new Equipe();
            Console.WriteLine("Escreva do último do time: ");
            time[2].nome = Console.ReadLine();
            Console.WriteLine("Escreva a atual pontuação do time: ");
            time[2].pontuacao = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < time.Length; i++){

            Console.WriteLine("Time:" + time[i].nome + "\n Pontuação: " + time[i].pontuacao);
            }
        }
    }
}

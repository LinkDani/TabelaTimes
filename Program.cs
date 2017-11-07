using System;
using System.Collections;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] time = new string[5];
            int[] pontuação = new int[5];

            
            Console.WriteLine("Escreva o nome do time: ");
            time[0] = Console.ReadLine();
            Console.WriteLine("Escreva a sua devida pontuação: ");
            pontuação[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o nome do próximo time: ");
            time[1] = Console.ReadLine();
            Console.WriteLine("Escreva a sua devida pontuação: ");
            pontuação[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o nome do próximo time: ");
            time[2] = Console.ReadLine();
            Console.WriteLine("Escreva a sua devida pontuação: ");
            pontuação[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o nome do próximo time: ");
            time[3] = Console.ReadLine();
            Console.WriteLine("Escreva a sua devida pontuação: ");
            pontuação[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o nome do último time: ");
            time[4] = Console.ReadLine();
            Console.WriteLine("Escreva a sua devida pontuação: ");
            pontuação[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("      \n A tabela de times: \n");
            Array.Sort(pontuação);

                for(int i = 0; i < time.Length; i++)
                {
                    Console.WriteLine("Time: " + time[i] + " Pontuação: " + pontuação[i]);
                }
                    
        }
    }
}

using System;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] time = new string[5];
            int[] pontuação = new int[5];

            pontuação[0] = 30;
            time[0] = "Inter ";
            pontuação[1] = 21;
            time[1] = "Grêmio ";
            pontuação[2] = 6;
            time[2] = "Santos ";
            pontuação[3] = 7;
            time[3] = "Criciúma ";
            pontuação[4] = 12;
            time[4] = "Palmeiras ";

                for(int i = 0; i < time.Length; i++)
                {
                    Console.WriteLine("Time: " + time[i] + "Pontuação: " + pontuação[i]);
                }

            

        }
    }
}

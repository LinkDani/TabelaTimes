using System;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] time = new string[5];

            time[0] = "Inter";
            time[1] = "Grêmio";
            time[2] = "Santos";
            time[3] = "Criciúma";
            time[4] = "Palmeiras";

            for(int i = 0; i < time.Length; i++)
            {
                Console.WriteLine(time[i]);
            }

        }
    }
}

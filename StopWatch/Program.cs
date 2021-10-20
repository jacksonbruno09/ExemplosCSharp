using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(20);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo =>  10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("O = Sair");

            Console.WriteLine("Quanto deseja esperar ? :" );

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

            int multiplier = 1;
            
            if(type == 'm')
                multiplier = 60;
            
            if(time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);

            Console.WriteLine(type);
            Console.WriteLine(time);

        }

        static void Start(int time){

            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

             Console.Clear();
             Console.WriteLine("Stop finalizado");
             Thread.Sleep(250);
            Menu();

        }
    }
}

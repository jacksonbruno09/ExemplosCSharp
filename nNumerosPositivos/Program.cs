using System;
using System.Collections.Generic;
using System.Linq;
using static System.Boolean;

namespace nNumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {


            //complete o código com sua solução
            int[] vetor = new int[20];
            IEnumerable<int> sequencia = Enumerable.Range(1, 20);
            IEnumerable<int> sequencia2 = sequencia.Reverse().ToArray();

            for (int c in sequencia)
            {
                Console.WriteLine(c);
            }

            foreach (int j in sequencia2)
            {
                Console.WriteLine(j);
            }


            /*             int n = int.Parse(Console.ReadLine());

                        //complete o código com sua solução 

                        for (int i = 1; i​​​​​​​ <= 10000; i++){        
                            if ( i % n == 2 ){                    
                                Console.WriteLine(i);
                            }
                        } */

            /*             double valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo valor: ");
                        double valor2 = double.Parse(Console.ReadLine());
                         Console.WriteLine("Terceiro valor: ");
                        double valor3 = double.Parse(Console.ReadLine());
                         Console.WriteLine("Quarto valor: ");
                        double valor4 = double.Parse(Console.ReadLine());
                         Console.WriteLine("Quinto valor: ");
                        double valor5 = double.Parse(Console.ReadLine());
                         Console.WriteLine("Sexto valor: ");
                        double valor6 = double.Parse(Console.ReadLine());

                        int ehPositivo = 0;

                        if (valor1 >0.0){
                            ehPositivo += 1;
                        }

                       //comtinue com sua solução

                        if (valor1 >0.0){
                            ehPositivo += 1;
                        }

                        if (valor2 >0.0){
                            ehPositivo += 1;
                        }

                        if (valor3 >0.0){
                            ehPositivo += 1;
                        }

                         if (valor4 >0.0){
                            ehPositivo += 1;
                        }

                         if (valor5 >0.0){
                            ehPositivo += 1;
                        }

                         if (valor6 >0.0){
                            ehPositivo += 1;
                        }

                        Console.WriteLine(ehPositivo + " valores positivos"); */
            Console.WriteLine("Hello World!");
        }
    }
}

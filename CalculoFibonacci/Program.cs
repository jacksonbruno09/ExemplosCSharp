using System;

namespace CalculoFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=1, aux;

            for (int i = 0; i​​​​​​​ < 60; i++)
            {
                aux=num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.WriteLine("{0}", num2);

            }

        }
    }
}

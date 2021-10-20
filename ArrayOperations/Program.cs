using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var meuArray = new int[5] {1,2,3,4,5};

            for (var i = 0; i < meuArray.Length; i++)
            {
                 Console.WriteLine(meuArray[i]);    
            }

            //-------------------------------------

            foreach (var item in meuArray)
                     Console.WriteLine(item);    

            //-------------------------------------   
            
            var primeiro = new int[5] {1,2,3,4,5};
            var segundo = new int[5] {1,2,3,4,5};;


        }
    }
}

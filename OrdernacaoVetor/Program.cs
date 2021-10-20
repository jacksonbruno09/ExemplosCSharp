using System;

namespace OrdernacaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            ParImpar();
        }

        static void OrdencaoCrescet()
        {
            int[] numeros = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numeros);
            Console.Write("\n\n");
            foreach (int p in numeros) Console.WriteLine(p);
        }

        static void OrdenacaoDescrescet()
        {

            int[] numeros = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n");

            Array.Reverse(numeros);
            foreach (int p in numeros)
            {
                for (int i = 2; i <= p; i++)
                {
                    if (p % i == 0 && i != p)
                    {
                        Console.WriteLine(p); // não é primo
                        break;
                    }

                    if (p % i == 0 && i == p)
                    {
                        Console.WriteLine(p + " é primo");
                        break;
                    }
                }
            }
        }


        static void OrdenacaoAleatoria()
        {
            string[] estudantes = new string[] {
                       "Anderson", "Castro", "Denise",
                       "Karla", "Katia", "Lazaro",
                       "Lucas", "Luciana", "Michel",
                       "Norma", "Priscila", "Rodrigo",
                       "Sergio", "Stenio", "Toninho" };

            // Para ordenar de forma aleatória precisamos de uma variável auxiliar.
            Random sorteio = new Random();
            for (int i = 0; i < estudantes.Length - 1; i++)
            {
                int j = sorteio.Next(i, estudantes.Length);
                var temp = estudantes[i];
                estudantes[i] = estudantes[j];
                estudantes[j] = temp;
            }

            int x = 0, grupo = 1;
            foreach (string p in estudantes)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("\n\nGrupo " + grupo + ":");
                    grupo++;
                }
                Console.WriteLine(" > " + p);
                x++;
            }
        }

        static void ParImpar()
        {
            const int tamanho = 5;
            var atividade = new int[tamanho];
            var i = 0;
            while (i < tamanho)
            {
                Console.WriteLine($"Insira o {i}° numero: ");
                if (int.TryParse(Console.ReadLine(), out atividade[i])) i++;
            }
            Console.WriteLine("Os seguintes numeros foram digitados: ");
            foreach (var item in atividade) 
                Console.WriteLine($"{item} é {((item & 1) == 0 ? "par" : "impar")}");
        }
    }
}

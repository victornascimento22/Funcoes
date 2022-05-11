using System;

namespace Divisorescomretorno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeros = Convert.ToInt32(Console.ReadLine());
            int divisores = Convert.ToInt32(Console.ReadLine());

            Divisores(numeros, divisores);
        }


        static int Divisores(int numero, int divisores)
        {
            for (int i = 1; i <= divisores; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"Número : {numero} Divisor : {i},");
                }
            }
            return 0; 
        }
    }
}

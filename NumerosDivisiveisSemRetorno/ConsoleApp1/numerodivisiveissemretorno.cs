using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            divisao();

        }

        static void divisao ()
        {
          
            int a;
            Console.Write("Digite o número para a verificação dos divisores");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de verificações");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a ; i++)
            {
                
                if (a % i == 0)
                {

                    Console.WriteLine($"Número : {a} Divisor : {i},");

                }
            }


            
        }
    }
}

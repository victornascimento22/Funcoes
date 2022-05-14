using System;

namespace Divisorescomretorno
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = Convert.ToInt32(Console.ReadLine());            
            int[] retorno = Divisores(numero);

            for(int i = 0; i < retorno.Length; i++)
            {
                if (retorno [i] == 0)
                {

                }else
                {
                    Console.WriteLine($"{retorno[i]}");
                }
            }
        }



        static int[] Divisores(int numero)
        {
            int[] vetor = new int[numero+1];

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    vetor[i] = i;
                    //Console.WriteLine($"Número : {numero} Divisor : {i},");
                }
            }
            return vetor;
        }
    }
}
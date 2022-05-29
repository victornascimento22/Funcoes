using System;

namespace mdc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vet1 = new int[n];
            n = Convert.ToInt32(Console.ReadLine());
            int[] vet2 = new int[n];
            n = Convert.ToInt32(Console.ReadLine());
            int[] vet3 = new int[n];
            int[] vetResul = new int[n];

            int v1 = vet1.Length;
            int v2 = vet2.Length;
            int v3 = vet3.Length;
            int menor = 0;

            //1o descobrir o menor array 
            //2o depois, dividir todos ao mesmo tempo: vet1[i] % i ==0 && vet2[i] % i ==0, iterando até o menor valor.
            //3o guardar todos os divisores em um array e mostrar na tela o maior resultado.

            if (v1 < v2 && v1 < v3)
            {
                Console.WriteLine("menor1");
                menor = v1;
            }
            else if (v2 < v1 && v2 < v3)
            {
                Console.WriteLine("menor2");
                menor = v2;
            }
            else
            {
                Console.WriteLine("menor3");
                menor = v3;
            }


            for (int i = 1; i <= menor; i++)
            {
                if (v1 % i == 0 && v2 % i == 0 && v3 % i == 0)
               
                    Console.WriteLine($"Número : {v1},{v2},{v3} Divisor : {i},");
                }
            }


        }
    }


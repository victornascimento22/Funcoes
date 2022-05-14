using System;

namespace arraynumerosgrandes
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            nGrandes();
        }

        static void nGrandes()
        {

            Console.WriteLine("Digite o numero de entradas");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [b+1];
            int maior = 0;


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maior)
                {
                    maior = a[i];
                }else if (a[i] == maior)
                {
                    Console.WriteLine($"Números iguais {a[i]} , Indice {i}");
                }
                


            }

            Console.WriteLine($"Maior valor {maior}");



          



        }
 

        }
    }


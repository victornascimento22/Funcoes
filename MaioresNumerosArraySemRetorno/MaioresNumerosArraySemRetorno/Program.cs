using System;

namespace MaioresNumerosArraySemRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = new int[10];
            int[] resultado = new int[10];
            int[] vetAux = new int[10];


            for (int i = 0; i < numb.Length; i++)
            {

                numb[i] = Convert.ToInt32(Console.ReadLine());
                vetAux[i] = numb[i];
            }

            resultado = NumerosIguais(numb,vetAux);


        }

        static int[] NumerosIguais(int[] numb,int[] vetAux )
        {
            int[] resultado = new int[10];
            int[] contVet = new int[10];
            int maior = 0;

            for (int i = 0; i < numb[i]; i++)
            {
                if (numb[i] > maior)
                {
                    maior = numb[i];
                }
            }
      
            Console.WriteLine($"Maior valor {maior}");

            return resultado;
            
        }

        }
    }

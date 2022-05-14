

using System;
using System.Collections.Generic;

namespace AlunosRetorno
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[] aprovados;
            double[] alunos = new double[10];


            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            aprovados = Aprovados(alunos);

       

        }

        static bool[] Aprovados(double[] alunos)
        {
            bool[] aprovados = new bool[10];
                        
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] < 7)
                {
                    Console.WriteLine("reprovado");
                }
                else
                {
                    Console.WriteLine("aprovado");
                }
            }

            return aprovados;
        }
        
    }

}
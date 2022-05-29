using System;

namespace exer1Notas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alunos = new string[10] { "Victor", "Andre", "Pedro", "Clara", "Maria", "Rodrigo", "Jose", "Roberto", "Julia", "Gabriela" };
            double[] notas1 = new double[10] { 10, 5, 8, 7, 6, 9, 5, 7, 9, 5 };
            double[] notas2 = new double[10] { 9, 4, 7, 4, 3, 8, 5, 7, 9, 5 };
            double[] notas3 = new double[10] { 10, 5, 3, 5, 6, 6, 5, 7, 6, 4 };
            double[] mediatotal = new double[10];
            double[] mediageral = new double[10];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"{i} - Nome dos alunos : {alunos[i]}");
            }

            for (int i = 0; i < notas1.Length; i++)
            {
                Console.Write($"\nNotas do primeiro bimestre - Aluno : {alunos[i]} - Nota : {notas1[i]}\n");
                //notas1[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < notas2.Length; i++)
            {
                Console.Write($"\nNotas do segundo bimestre - Aluno : {alunos[i]} - Nota : {notas2[i]}\n");
                //notas2[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < notas3.Length; i++)
            {
                Console.Write($"\nNotas do terceiro bimestre - Aluno : {alunos[i]} - Nota : {notas3[i]}\n");
                //notas3[i] = Convert.ToDouble(Console.ReadLine());
            }


            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write($"\nNota Geral - Aluno : {alunos[i]} - Nota : {notas1[i]} + {notas2[i]} + {notas3[i]} = {mediatotal[i]}\n");
            }

            double[] menor = descartanota(notas1, notas2, notas3);
        }

        static double[] descartanota(double[] menor1,double[] menor2,double[] menor3)
        {

            double[] menor = new double[10];
            

            for (int i = 0; i < 10; i++)
            {
               for(int j = 0; i < 10; i++)
                {
                    for (int y= 0; i < 10; i++)
                    {
                        if((menor1[i] < menor2[i] && menor2[i] < menor3[i]))
                        {


                        }else if((menor2[i] < menor1[i] && menor1[i] < menor3[i]))
                        {


                        }else if ((menor3[i] < menor2[i] && menor2[i] < menor3[i]))
                        {


                        }//else if (())
                        {



                        }

                        
                    }

                }
            
            
            }
            return menor;
                
    }
    }
}


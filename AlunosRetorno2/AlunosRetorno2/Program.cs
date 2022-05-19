using System;

namespace AlunosRetorno2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] aprovados = new bool[10]; // vetor retorna valor booleano se aluno foi aprovado ou nao
            double[] alunos = new double[10]; // vetor armazena nota dos alunos

            //preenche vetor
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = Convert.ToDouble(Console.ReadLine());

            }
            // Chama a função Aprovados e envia as notas armazenadas em alunos para dentro da função processa o bloco de instrução e retorna o resultado e armazena em aprovados.
            aprovados = Aprovados(alunos);

        }

        //função para retornar um resultado booleano se o aluno foi aprovado ou reprovado
        //a função retorna um booleano, a funcao vai ser chamada e vai ser armazenada 10 notas, o bloco de instrucoes sera executado e retornara o valor para a variavel aprovados

        static bool[] Aprovados(double[] alunos)
        {
            //vai armazenar e gerar o resultado booleano vindo da variavel alunos

            bool[] aprovados = new bool[10];
            
            //algoritmo de condicao dos vetores das notas
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos.Length > 7)
                {
                    Console.WriteLine($"{i} Aprovado");
                }
                else if (alunos.Length < 7)
                {
                    Console.WriteLine($"{i} Reprovado");
                }
            }
            // analisa os valores dentro de alunos e aplica a condicao .
            // aprovados armazena os valores booleanos
            return aprovados;

        }





        
    }

}
using System;

namespace CalculadoraFuncoesComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int respostaSoma;
            int respostaSubtracao;
            int respostaMultiplicacao;
            int respostaDivisao;
            int opcao;


            do
            {

                Console.Write("1 - Soma 2 - Subtração 3 - Divisão 4 - Multiplicacao 0 - Finalizar Programa\n");
                Console.Write("Digite uma opcao : ");
                opcao = Convert.ToInt16(Console.ReadLine()); 


                switch (opcao)
                {
                    case 1:
                        {
                       
                            respostaSoma = Soma(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            
                            Console.WriteLine($"Resposta Soma : {respostaSoma}");
                        }
                        break;

                    case 2:
                        {
                            respostaSubtracao = subtracao(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine($"Resposta Subtração : {respostaSubtracao}");
                        }
                        break;

                    case 3:
                        {
                            respostaDivisao = divisao(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine($"Resposta Divisao : {respostaDivisao}");
                        }
                        break;

                    case 4: 
                        {
                            respostaMultiplicacao = multiplicacao(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine($"Resposta Multiplicacao : {respostaMultiplicacao}");
                        }
                        break;
                }
            } while (opcao != 0);                    
        }

        static int Soma(int a, int b)
        {    
            return a + b;

        }

        static int subtracao(int a, int b)
        {
            return a - b;
        }

        static int divisao (int a, int b)
        {

            if (b == 0)
            {
                Console.WriteLine("Não é possivel dividir um valor por 0");
            }
            return a / b;

        }

        static int multiplicacao (int a, int b)
        {

            return a * b;

        }


    }
}

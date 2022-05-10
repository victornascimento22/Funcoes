using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Calculadora com funções\n");
                Console.WriteLine("1 - Soma 2 - Divisão 3 - Subtração 4 - Multiplicacao 0 - Finalizar o Programa\n");
                Console.Write("Digite a opção desejada : ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        {
                            Soma();
                            Console.Write("\nPara finalizar o programa digite 0 ou digite qualquer número para continuar\n ");
                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 2:
                        {
                            Divisao();
                            Console.Write("\nPara finalizar o programa digite 0 ou digite qualquer número para continuar\n ");
                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 3:
                        {
                            Subtracao();
                            Console.Write("\nPara finalizar o programa digite 0 ou digite qualquer número para continuar\n ");
                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 4:
                        {
                            Multiplicacao();
                            Console.Write("\n\nPara finalizar o programa digite 0 ou digite qualquer número para continuar\n\n ");
                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                }
            } while (opcao != 0);
        }
        static void Soma()
        {
            double a, b;
            double resultado;

            Console.Write("\nDigite o valor para A : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o valor para B : ");
            b = Convert.ToDouble(Console.ReadLine());

            resultado = a + b;

            Console.WriteLine($"\nO valor da soma é : {resultado}\n");

        }

        static void Divisao()

        {

            double a, b;
            double resultado;

            Console.Write("\nDigite o dividendo : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o divisor: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.Write("\nNão é possivel dividir um numero por 0\n");
                
            }else if (b != 0)
            {
                resultado = a / b;
                Console.WriteLine($"\nO valor da divisao é : {resultado}\n");
            }
            }


        static void Subtracao()
        {
            double a, b;
            double resultado;

            Console.Write("\nDigite o valor para A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o valor para B: ");
            b = Convert.ToDouble(Console.ReadLine());

            resultado = a - b;

            Console.WriteLine($"\nO valor da subtracao é : {resultado}\n");
        }

        static void Multiplicacao()
        {
            double a, b;
            double resultado;

            Console.Write("\nDigite o valor para A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o valor para B: ");
            b = Convert.ToDouble(Console.ReadLine());

            resultado = a * b;

            Console.WriteLine($"\nO valor da multiplicacao é : {resultado}\n");
        }
    }
}

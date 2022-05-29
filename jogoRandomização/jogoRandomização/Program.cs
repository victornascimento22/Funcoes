using System;

namespace jogoRandomização
{
    class Program
    {
        static void Main(string[] args)
        { 
           Menu();
        }

        static void Menu()
        {
            int opcao = 0;
            int aleatorio = 0;
                
                do
                {
                Console.WriteLine("Bem vindo a jogo de adivinhação");
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("1 - Jogar 2 - Como jogar 3 - Sobre 0 - Sair do jogo");
                Console.Write("Sua opção : ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        {

                            int n = Convert.ToInt32(Console.ReadLine());

                            int tentativasAux = 0+1;
                            int tentativasAux2 = 10;
                            int jogador = 0;
                            

                            Random nRand = new Random();
                            aleatorio = nRand.Next(n);

                            for (int i = 0; i < n; i++) {
                                Console.Write("Tente adivinhar o número : ");
                                jogador = Convert.ToInt32(Console.ReadLine());

                            if (jogador == aleatorio){
                                    Console.WriteLine("Você acertou, parabéns\n");
                                    Console.WriteLine($"Tentativas : {tentativasAux}");

                                    break;
                                
                                }else if (jogador != aleatorio)
                                {
                                    Console.WriteLine("Você errou, tente denovo\n");
                                    tentativasAux2--;
                                    Console.WriteLine($"Tentativas restantes {tentativasAux2}");
                                    tentativasAux++;

                                    if (tentativasAux2 == 0)
                                    {
                                        Console.WriteLine("Você esgotou as suas tentativas");
                                        Console.WriteLine("Game Over");
                                        Console.ReadLine();
                                    }
                                }
                              }
                            }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Escolha um número até acertar");
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Escreva um jogo, usando funções, em que o usuário informa um valor e o programa gerará um valor aleatório. O usuário deve ir digitando até acertar.");
                       }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Digite qualquer tecla para finalizar");
                            Console.ReadLine();

                        }
                        break;

                }

                }while (opcao != 0) ;



 
            }
        }
    }


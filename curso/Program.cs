using System;
using curso.Exercicios;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("2. Exercício 2");
            Console.WriteLine("3. Exercício 3");
            Console.WriteLine("4. Exercício 4");
            Console.WriteLine("5. Exercício 5");
            Console.WriteLine("6. Exercício 6");
            Console.WriteLine("7. Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio01.Executar();
                    break;
                case 2:
                    Exercicio02.Executar();
                    break;
                case 3:
                    Exercicio03.Executar();
                    break;
                case 4:
                    Exercicio04.Executar();
                    break;
                case 5:
                    Exercicio05.Executar();
                    break;
                case 6:
                    Exercicio06.Executar();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}

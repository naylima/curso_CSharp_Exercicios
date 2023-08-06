using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.Exercicios
{
    internal class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a quantidade de números inteiros que deseja digitar:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int quantidade_in = 0, quantidade_out = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número { i +1 }:");
                int valor = Convert.ToInt32(Console.ReadLine());

                if ( valor >= 10 && valor <= 20 )
                    quantidade_in++;
                else 
                    quantidade_out++;
            }

            Console.WriteLine($"{quantidade_in} in");
            Console.WriteLine($"{quantidade_out} out");
        }
    }
}

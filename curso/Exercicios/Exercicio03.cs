using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.Exercicios
{
    internal class Exercicio03
    {
        public static void Executar ()
        {
            Console.WriteLine("Digite a quantidade atual do produto em estoque:");
            int quantidateAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidate máxima do produto em estoque:");
            int quantidadeMaxima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade mínima do produto em estoque:");
            int quantidadeMinima = Convert.ToInt32(Console.ReadLine());

            double quantidadeMedia = CalcularMedia(quantidadeMaxima, quantidadeMinima);

            if (quantidateAtual > quantidadeMedia)
                Console.WriteLine("Não efetuar compra.");
            else
                Console.WriteLine("Efetuar compra.");
        }

        private static double CalcularMedia(int quantidateMaxima, int quantidateMinima)
        {
            double media = ( quantidateMaxima + quantidateMinima ) / 2;
            return media;
        }
    }
}

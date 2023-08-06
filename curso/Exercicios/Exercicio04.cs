using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.Exercicios
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            int[] vetor = new int[100];
            Random random = new Random();

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(int.MinValue, int.MaxValue);
            }

            int maiorNumero = vetor[0], menorNumero = vetor[0];
            int posicaoMaior = 0, posicaoMenor = 0;

            for(int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorNumero)
                {
                    maiorNumero = vetor[i];
                    posicaoMaior = i;
                }
                
                if (vetor[i] < menorNumero)
                {
                    menorNumero = vetor[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine($"O maior valor gerador foi {maiorNumero} na posição {posicaoMaior}");
            Console.WriteLine($"O menor valor gerador foi {menorNumero} na posição {posicaoMenor}");
        }
    }
}

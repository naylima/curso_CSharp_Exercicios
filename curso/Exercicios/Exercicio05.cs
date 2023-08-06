using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.Exercicios
{
    internal class Exercicio05
    {
        public static void Executar()
        {
            int opcao, alcool = 0, gasolina = 0, diesel = 0;

            do
            {
                Console.WriteLine(
                    "Digite o tipo de combustível abastecido: \n" +
                    "1.Álcool \n" +
                    "2.Gasolina \n" +
                    "3.Diesel \n" +
                    "4.Fim "
                );

                opcao = Convert.ToInt32( Console.ReadLine() );

                while (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("Digite um número válido!");
                    opcao = Convert.ToInt32(Console.ReadLine());
                }

                switch ( opcao )
                {
                    case 1: 
                        alcool++;
                        break;
                    case 2: 
                        gasolina++;
                        break;
                    case 3: 
                        diesel++;
                        break;
                }

            }
            while (opcao != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}

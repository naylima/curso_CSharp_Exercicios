using System;

namespace curso.Exercicios
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva o valor base: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            double imposto = CalcularImposto(valor);

            Console.WriteLine($"O total de imposto a pagar é {imposto:C}.");
        }

        private static double CalcularImposto(double valor)
        {
            if (valor <= 1200)
                return 0;
            else if (valor > 1200 && valor <= 2500)
                return valor * .1;
            else if (valor > 2500 && valor <= 5000)
                return valor * .15;
            else
                return valor * .2;
        }
    }
}

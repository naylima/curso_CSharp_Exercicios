using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso.Exercicios
{
    internal class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o número de horas trabalhadas no mês:");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário por hora trabalhada:");
            double salarioPorHora = Convert.ToDouble(Console.ReadLine());

            double salario = CalcularSalario(horasTrabalhadas, salarioPorHora);

            Console.WriteLine($"O salário a receber é {salario:C}.");
        }

        private static double CalcularSalario(int horasTrabalhadas, double salarioPorHora)
        {
            int horasRegulares = Math.Min(horasTrabalhadas, 40 * 4);
            int horasExtras = Math.Max(0, horasTrabalhadas - 40 * 4);

            double salarioRegular = salarioPorHora * horasRegulares;
            double salarioExtra = salarioPorHora * horasExtras;

            return salarioRegular + salarioExtra;
        }
    }
}

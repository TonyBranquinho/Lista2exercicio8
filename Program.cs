using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double taxa = 0;

            Console.WriteLine("Digite um valor com duas casas decimais,salário de uma pessoa de Lisarb");
            double salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 2000.00) {
                taxa = 0.0;
            }
            else if (salario <= 3000.00) {
                taxa = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500.00) {
                taxa = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else if (salario > 4500.00) {
                taxa = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (taxa == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + taxa.ToString("F2", CI));
            }
        }
    }
}
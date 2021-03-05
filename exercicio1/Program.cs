using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Cálculo com IR-----------");

            InvestimentoComIR investimentoComIR = new InvestimentoComIR(5000, 1.2);
            double lucroComIR = Math.Round(investimentoComIR.calcularLucro(17), 2);
            double valorTotalComIR = Math.Round((investimentoComIR.ValorInicial + lucroComIR), 2);

            Console.WriteLine("Lucro de: " + lucroComIR);
            Console.WriteLine("Quantida total de: " + valorTotalComIR);

            Console.WriteLine("");
            Console.WriteLine("----------Cálculo sem IR-----------");

            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(3000, 0.7);
            double lucroSemIR = Math.Round(investimentoSemIR.calcularLucro(10), 2);
            double valorTotalSemIR = Math.Round((investimentoSemIR.ValorInicial + lucroSemIR), 2);

            Console.WriteLine("Lucro de: " + lucroSemIR);
            Console.WriteLine("Quantida total de: " + valorTotalSemIR);

        }
    }
}

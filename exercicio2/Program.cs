using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor Inicial:");
            double inicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculando a uma taxa de 0,35% com IR e 0,3% sem IR, no período de 36 meses.");
            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(inicial, 0.3);
            InvestimentoComIR investimentoComIR = new InvestimentoComIR(inicial, 0.35);

            for (int i = 1; i <= 36; i++)
            {
                double lucroSemIR = investimentoSemIR.calcularLucro(i);
                double lucroComIR = investimentoComIR.calcularLucro(i);
                Console.WriteLine($"Mês: {i} | Investimento sem IR: {Math.Round(lucroSemIR, 2)} | Investimento com IR: {Math.Round(lucroComIR, 2)}");
            }

        }
    }
}

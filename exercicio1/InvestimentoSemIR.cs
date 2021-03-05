using System;

namespace exercicio1
{
    public class InvestimentoSemIR : Investimento
    {
        public InvestimentoSemIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {

        }

        public override double calcularLucro(int meses)
        {
            if (ValorInicial < 1000)
            {
                Console.WriteLine("Digite um valor inicial acima de 1000");
                return 0;
            }
            else
            {
                return base.calcularLucro(meses);
            }
        }
    }
}
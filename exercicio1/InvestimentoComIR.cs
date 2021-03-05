using System;

namespace exercicio1
{
    public class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {

        }

        public override Double calcularLucro(int meses)
        {
            double desconto = 0;
            if (meses < 6)
            {
                desconto = 22.5;
            }
            else if (meses >= 6 && meses < 12)
            {
                desconto = 20;
            }
            else if (meses >= 12 && meses < 24)
            {
                desconto = 17.5;
            }
            else if (meses >= 24)
            {
                desconto = 15;
            }
            else
            {
                return 0;
            }

            double lucro = base.calcularLucro(meses);
            return lucro - (lucro * desconto / 100);
        }
    }
}
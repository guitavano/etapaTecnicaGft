using System;

namespace exercicio1
{
    public class Investimento
    {
        public Investimento(double valorInicial, double jurosMensais)
        {
            this.ValorInicial = valorInicial;
            this.JurosMensais = jurosMensais;
        }

        private double valor;
        public double ValorInicial
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        private double juros;
        public double JurosMensais
        {
            get { return this.juros; }
            set { this.juros = value / 100; }
        }

        public virtual double calcularLucro(int meses)
        {
            return (ValorInicial * Math.Pow((1 + JurosMensais), meses)) - ValorInicial;
        }
    }
}
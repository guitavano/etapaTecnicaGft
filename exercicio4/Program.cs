using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continua = true;
            double somatorio = 0;
            while (continua)
            {
                Console.WriteLine("Digite um número:");
                double digitado = Convert.ToDouble(Console.ReadLine());

                if (digitado < 0)
                {
                    Console.WriteLine("Digite apenas números positivos.");
                }
                else if (digitado + somatorio >= 157)
                {
                    somatorio += digitado;
                    Console.WriteLine($"O somatório foi: {somatorio}");
                    continua = false;
                }
                else
                {
                    somatorio += digitado;
                }
            }
        }
    }
}
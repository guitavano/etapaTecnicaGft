using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o multiplicando:");
            int multiplicando = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o início do intervalo multiplicador:");
            int multiplicadorInicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o fim do intervalo multiplicador:");
            int multiplicadorFim = Convert.ToInt32(Console.ReadLine());

            if (multiplicando < 0 || multiplicando > 5000)
            {
                Console.WriteLine("Multiplicando deve ser um número positivo menor que 5000");
            }
            else if (multiplicadorInicio < 0 || multiplicadorInicio > 5000 || multiplicadorFim < 0 || multiplicadorFim > 5000)
            {
                Console.WriteLine("Os multiplicadores devem ser números positivos menores que 5000");
            }
            else if ((multiplicadorFim - multiplicadorInicio) >= 10)
            {
                Console.WriteLine("O intervalo não pode ter uma diferença maior que 10");
            }
            else if (multiplicadorInicio >= multiplicadorFim)
            {
                Console.WriteLine("O início do intervalo deve ser maior que seu fim");
            }
            else
            {
                for (int i = multiplicadorInicio; i <= multiplicadorFim; i++)
                {
                    Console.WriteLine($"{multiplicando} X {i} = " + (multiplicando * i));
                }
            }

        }
    }
}

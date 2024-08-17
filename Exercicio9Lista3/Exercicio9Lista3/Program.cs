using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa os dois primeiros números da série de Fibonacci
            int num1 = 1;
            int num2 = 1;

            // Exibe os dois primeiros números
            Console.WriteLine($"Os trinta primeiros valores da série de Fibonacci:");

            // Loop para calcular e exibir os trinta primeiros valores
            for (int i = 0; i < 30; i++)
            {
                // Exibe o número atual da série
                Console.WriteLine(num1);

                // Calcula o próximo número da série somando os dois últimos números
                int proximoNumero = num1 + num2;

                // Atualiza os dois últimos números para os próximos cálculos
                num1 = num2;
                num2 = proximoNumero;
            }
        }
    }
}

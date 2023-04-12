using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char opcao;

            do
            {
                double num1, num2, resultado = 0;
                char operador;

                Console.WriteLine("Bem-vindo à  minha calculadora!");
                Console.WriteLine("Insira o primeiro número:");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o segundo número:");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o operador (+, -, *, /):");
                operador = char.Parse(Console.ReadLine());

                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;

                    case '-':
                        resultado = num1 - num2;
                        break;

                    case '*':
                        resultado = num1 * num2;
                        break;

                    case '/':
                        resultado = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Operador inválido!");
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);

                do
                {
                    Console.WriteLine("Deseja fazer outra conta? (s/n)");
                    opcao = char.Parse(Console.ReadLine());
                } while (opcao != 's' && opcao != 'n');

                if (opcao == 's')
                {
                    Console.Clear(); // limpa a tela para a próxima conta
                }

            } while (opcao == 's');








        }
    }
}

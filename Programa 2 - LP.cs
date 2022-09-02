using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double resultado, numero1, numero2;

            Console.WriteLine("Cauculadora");
            Console.WriteLine("escolha a operação");
            Console.WriteLine("Soma");
            Console.WriteLine("subtração");
            Console.WriteLine("multiplicação");
            Console.WriteLine("divisão");

            opcao = Console.ReadLine();

            switch (opcao)
            {

                case "soma":

                    Console.Clear();
                    Console.WriteLine("insira o primeiro numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o primeiro numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 + numero2;

                    Console.WriteLine(resultado);
                    break;

                case "subtração":

                    Console.Clear();
                    Console.WriteLine("insira o primeiro numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o primeiro numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 - numero2;

                    Console.WriteLine(resultado);
                    break;

                case "multiplicação":

                    Console.Clear();
                    Console.WriteLine("insira o primeiro numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o primeiro numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2;

                    Console.WriteLine(resultado);
                    break;

                case "divisão":

                    Console.Clear();
                    Console.WriteLine("insira o primeiro numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o primeiro numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 / numero2;

                    Console.WriteLine(resultado);
                    break;
            }

            Console.ReadKey();
        }
    }
}

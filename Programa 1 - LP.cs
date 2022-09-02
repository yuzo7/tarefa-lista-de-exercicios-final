using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_cauculo_area
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double resultado, numero1, numero2, numero3;

            Console.WriteLine("Exemplo switch Case");
            Console.WriteLine("escolha a operação");
            Console.WriteLine("1 - Area do quadrilatero");
            Console.WriteLine("2 - Area do trapezio");
            Console.WriteLine("3 - Area do triangulo");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("insira a medida do primeiro lado do quadrilatero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira a medida do segundo lado do quadrilátero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2;

                    Console.WriteLine(resultado);
                    break;

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("insira o valor da base maior do trapezio");
                        numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("insira o valor da base menor do trapezio");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("insira o valor da altura do trapezio");
                        numero3 = Convert.ToDouble(Console.ReadLine());

                        resultado = ((numero1 + numero2) * numero3) / 2;

                        Console.WriteLine(resultado);
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("insira o valor da altura do triangulo");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o valor da base do triangulo");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2;

                    Console.WriteLine(resultado);
                    break;
                    {

                        Console.ReadKey();

                    }




            }
        }
    }
}

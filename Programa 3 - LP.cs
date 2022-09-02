using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_3__
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double nome1, nome2, nome3, nome4;

            Console.WriteLine("Digite o nome do professor");

            opcao = (Console.ReadLine());

            switch (opcao)
            {

                case "paulo":
                    Console.Clear();
                    Console.WriteLine("LP");
                    nome1 = Convert.ToDouble(Console.ReadLine());

                    break;

                case "mario":
                    Console.Clear();
                    Console.WriteLine("MATEMATICA");
                    nome2 = Convert.ToDouble(Console.ReadLine());

                    break;

                case "meire":
                    Console.Clear();
                    Console.WriteLine("PORTUGUES");
                    nome3 = Convert.ToDouble(Console.ReadLine());

                    break;

                case "jose":
                    Console.Clear();
                    Console.WriteLine("QUIMICA");
                    nome4 = Convert.ToDouble(Console.ReadLine());

                    break;




            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, subtotal = 0;
     

            Console.WriteLine("menu");
            Console.WriteLine("1 celular-- 1000");
            Console.WriteLine("2 computador-- 4000");
            Console.WriteLine("3 pelicula-- 20");
            Console.WriteLine("4 fones de ouvido-- 30");
            Console.WriteLine("5 carregador-- 40");
            Console.WriteLine("0 encerar");

            opcao = Convert.ToInt32(Console.ReadLine());

            do
            {

                switch (opcao == 1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1- celular");
                        subtotal = subtotal + 1000;
                        Console.WriteLine("você escolheu o celular");
                        Console.WriteLine("seu subtotal foi de"  + subtotal);

                        Console.ReadKey();
                        break;
                


                
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2- computador");
                        subtotal = subtotal + 4000;
                        Console.WriteLine("você escolheu o computador");
                        Console.WriteLine("seu subtotal foi de" + subtotal);

                        Console.ReadKey();
                        break;

                


                    case 3:
                        Console.Clear();
                        Console.WriteLine("3- pelicula");
                        subtotal = subtotal + 20;
                        Console.WriteLine("você escolheu o pelicula");
                        Console.WriteLine("seu subtotal foi de" + subtotal);

                        Console.ReadKey();
                        break;




                    case 4:
                        Console.Clear();
                        Console.WriteLine("4- fones de ouvido");
                        subtotal = subtotal + 30;
                        Console.WriteLine("você escolheu o fone de ouvido");
                        Console.WriteLine("seu subtotal foi de" + subtotal);

                        Console.ReadKey();
                        break;




                    case 5:
                        Console.Clear();
                        Console.WriteLine("5- carregador");
                        subtotal = subtotal + 40;
                        Console.WriteLine("você escolheu o carregador");
                        Console.WriteLine("seu subtotal foi de" + subtotal);

                        Console.ReadKey();
                        break;




                    case 0:
                        Console.Clear();
                        Console.WriteLine("0- encerrar");

                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);


        }
    }
}

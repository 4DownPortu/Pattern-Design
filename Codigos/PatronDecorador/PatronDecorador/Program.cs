using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public class cafeteria
    {
        public void Ticket()
        {
            
        }
        public void Condimentos()
        {
            Console.WriteLine("---MENU CONDIMENTOS---");
        }
        public void Menu()
        {
            int cafe, desicion;
            double costo;

            Console.Clear();
            Console.WriteLine("Bienvenido a la cafeteria PortuCafe");
            Console.WriteLine("¿Que desea tomar el dia de hoy?\n\n");

            Console.WriteLine("---MENU---");
            Console.WriteLine("1. House Blend");
            Console.WriteLine("2. Mocha");
            Console.WriteLine("3. Expresso");

            cafe = Convert.ToInt32(Console.ReadLine());
            desicion = Convert.ToInt32(Console.ReadLine());

            switch (cafe)
            {
                case 1:
                    Console.WriteLine("Excelente desicion tu cafe es un House Blend");
                    costo = 50;

                    Console.WriteLine("¿Gusta algun condimento?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");

                    if (desicion == 1)
                    {
                        Condimentos();
                    }
                    else if (desicion == 2)
                    {
                        Console.WriteLine("Excelente el Ticket de compra es el siguente:");
                        Ticket();
                    }


                    break;





                default:
                    break;
            }



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

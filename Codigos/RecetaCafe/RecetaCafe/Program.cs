using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
Alumno:Portugal Quintero Adolfo.
No.Control:C17212536.
Materia:Patrones de diseño.
Profesor: Jose de Jesus Parra Galavis.
*/


namespace RecetaCafe
{
    public class Coffee

    {
        public void Menu()
        {
            int seleccion;
            Coffee receta = new Coffee();
            
            Console.Clear();

            Console.WriteLine("Bienvenido a Portucafe el mejor cafe para tu corazon.");
            Thread.Sleep(2000);
            Console.WriteLine("Gusta Cafe o Te");
            Console.WriteLine("Cafe = 1 \nTe = 2 ");
            seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    receta.Coffe();
                    break;
                case 2:
                    receta.Tea();
                    break;
                default:
                    Console.WriteLine("Seleccione unicamente una de las opciones posibles \nPresiona cualquier tecla:");
                    Console.ReadKey();
                    Menu();
                    break;             
            }

        }
        public void Coffe()
        {
            string seleccion;
            Console.Clear();

            Console.WriteLine("Hirviendo agua");
            Thread.Sleep(2000);
            Console.WriteLine("Moliendo granos de cafe");
            Thread.Sleep(2000);
            Console.WriteLine("Sirviendolo en taza");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Desea azucar y leche?");
            Console.WriteLine("Si = 1 \nNo = 2");

            seleccion = Console.ReadLine();

            Console.Clear();

            if (seleccion == "1" )
            {
                Console.WriteLine("Perfecto");
                Thread.Sleep(2000);
                Console.WriteLine("Añadiendo azucar y leche");
                Thread.Sleep(2000);
                Console.WriteLine("Costo: $50 pesos");
            }
            else if (seleccion=="2")
            {
                Console.WriteLine("Perfecto");
                Thread.Sleep(2000);

                Console.WriteLine("Costo: $50 pesos");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Seleccione unicamente una de las opciones posibles \nPresiona cualquier tecla:");
                Console.ReadKey();
                Coffe();
            }

            Console.ReadKey();

        }

        public void Tea()
        {
            string seleccion;
            Console.Clear();

            Console.WriteLine("Hirviendo agua");
            Thread.Sleep(2000);
            Console.WriteLine("Colando el te");
            Thread.Sleep(2000);
            Console.WriteLine("Sirviendolo en taza");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("Desea limon?");
            Console.WriteLine("Si = 1 \nNo = 2");

            seleccion = Console.ReadLine();

            Console.Clear();

            if (seleccion == "1")
            {
                Console.WriteLine("Perfecto");
                Thread.Sleep(2000);
                Console.WriteLine("Añadiendo limon");
                Thread.Sleep(2000);
                Console.WriteLine("Costo: $50 pesos");
            }
            else if (seleccion == "2")
            {
                Console.WriteLine("Perfecto");
                Thread.Sleep(2000);

                Console.WriteLine("Costo: $50 pesos");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Seleccione unicamente una de las opciones posibles \nPresiona cualquier tecla:");
                Console.ReadKey();
                Tea();
            }

            Console.ReadKey();

        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            Coffee receta = new Coffee();

            receta.Menu();

        }
    }
}

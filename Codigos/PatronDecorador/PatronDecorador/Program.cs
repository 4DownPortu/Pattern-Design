using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    
    public class cafeteria
    {
        double costototal;
        List<string> items = new List<string>();
        public void Ticket()
        {
            
        }
        public void Condimentos()
        {
            int desicion, desicion2;

            Console.WriteLine("---MENU CONDIMENTOS---");
            Console.WriteLine("Que condimento gusta añadir?");
            Console.WriteLine("Mocha--------------- $ 15");
            Console.WriteLine("Whip--------------- $ 15");
            desicion = Convert.ToInt32(Console.ReadLine());

            if (desicion == 1)
            {
                Console.WriteLine("Muy bien, añadiste Mocha como condimento");
                items.Add("Mocha");

                Console.WriteLine("Quieres algun otro condimento?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");

                desicion2 = Convert.ToInt32(Console.ReadLine());

                if (desicion2 == 1)
                {
                    Condimentos();
                }
                else if(desicion2 == 2)
                {
                    Ticket();
                }

            }
            else if(desicion == 2)
            {
                Console.WriteLine("Muy bien, añadiste Whip como condimento");
                items.Add("Whip");

                Console.WriteLine("Quieres algun otro condimento?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");

                desicion2 = Convert.ToInt32(Console.ReadLine());

                if (desicion2 == 1)
                {
                    Condimentos();
                }
                else if (desicion2 == 2)
                {
                    Ticket();
                }

            }
            else
            {

            }
        }


        public void Menu()
        {
            int cafe, desicion, desicion2;


            Console.Clear();
            Console.WriteLine("Bienvenido a la cafeteria PortuCafe");
            Console.WriteLine("¿Que desea tomar el dia de hoy?\n\n");

            Console.WriteLine("---MENU---");
            Console.WriteLine("1. House Blend");
            Console.WriteLine("2. Mocha");
            Console.WriteLine("3. Expresso");

            cafe = Convert.ToInt32(Console.ReadLine());
            
            

            switch (cafe)
            {
                case 1:
                    Console.WriteLine("Excelente desicion tu cafe es un House Blend");
                    items.Add("House Blend");
                    costototal = 50;

                    Console.WriteLine("Quieres condimentos en tu cafe?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    desicion = Convert.ToInt32(Console.ReadLine());

                    if (desicion == 1)
                    {
                        Condimentos();
                    }
                    else if (desicion == 2)
                    {
                        Console.WriteLine("Quieres algun otro cafe?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        desicion2 = Convert.ToInt32(Console.ReadLine());

                        if (desicion2 == 1)
                        {
                            Menu();
                        }
                        else if (desicion2 == 2)
                        {
                            Ticket();
                        }

                    }



                    break;

                case 2:
                    Console.WriteLine("Excelente desicion tu cafe es un Mocha");
                    items.Add("Mocha");
                    costototal = 50;

                    Console.WriteLine("Quieres condimentos en tu cafe?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    desicion = Convert.ToInt32(Console.ReadLine());

                    if (desicion == 1)
                    {
                        Condimentos();
                    }
                    else if (desicion == 2)
                    {
                        Console.WriteLine("Quieres algun otro cafe?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        desicion2 = Convert.ToInt32(Console.ReadLine());

                        if (desicion2 == 1)
                        {
                            Menu();
                        }
                        else if (desicion2 == 2)
                        {
                            Ticket();
                        }

                    }


                    break;

                case 3:
                    Console.WriteLine("Excelente desicion tu cafe es un Expresso");
                    items.Add("Expresso");
                    costototal = 50;

                    Console.WriteLine("Quieres condimentos en tu cafe?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    desicion = Convert.ToInt32(Console.ReadLine());

                    if (desicion == 1)
                    {
                        Condimentos();
                    }
                    else if (desicion == 2)
                    {
                        Console.WriteLine("Quieres algun otro cafe?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        desicion2 = Convert.ToInt32(Console.ReadLine());

                        if (desicion2 == 1)
                        {
                            Menu();
                        }
                        else if (desicion2 == 2)
                        {
                            Ticket();
                        }

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

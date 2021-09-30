using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Alumno:Portugal Quintero Adolfo.
No.Control:C17212536.
Materia:Patrones de diseño.
Profesor: Jose de Jesus Parra Galavis.
*/


public  class Duck
{
    string[] pato = new string[6];
    public void Graznar ()
    {
        Console.Clear();
        //Decicion de si graznara o no.
        int desicion;
        string graznar = "Graznar";
        Console.WriteLine("Quieres que tu pato grazne? \n (Digite el numero segun lo deseado)");
        Console.WriteLine("1.Si");
        Console.WriteLine("2.No");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:

                Console.WriteLine("Muy bien ahora tu pato puede" + graznar);
                break;

            case 2:

                Console.WriteLine("Esta bien, no hay problema no todos los patos deben de graznar.");
                break;


            default:
                Console.WriteLine("Selecciona unicamente una de las opciones posibles:");
                Console.ReadKey();
                Volar();
                break;


        }



    }
    public void Volar()
    {
        Console.Clear();
        //Decicion de si volara o no.
        int desicion;
        
        Console.WriteLine("Como quieres que tu pato vuele? \n (Digite el numero segun lo deseado)");
        Console.WriteLine("1.Alto");
        Console.WriteLine("2.Bajo");
        Console.WriteLine("3.No vuela");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:

                Console.WriteLine("Muy bien ahora tu pato puede volar alto");

                pato[1] = "Si";
                pato[2] = "Alto";
                break;

            case 2:

                Console.WriteLine("Muy bien, ahora tu pato vuela bajo");
                pato[1] = "Si";
                pato[2] = "Bajo";
                break;

            case 3:

                Console.WriteLine("Esta bien no todos los patos deben de volar");
                pato[1] = "No";
                pato[2] = "No vuela";
                break;


            default:
                Console.WriteLine("Selecciona unicamente una de las opciones posibles:");
                Console.ReadKey();
                Volar();
                break;


        }

     



    }

    
    public void tipopatos()
    {
        Console.Clear();
        int tipo;
        //Seleccion de patos
        Console.WriteLine("Seleccione un tipo de pato: \n (Digite el numero segun el pato deseado)");
        tipo =Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("1. Mallard Duck");
        Console.WriteLine("2. RedHead Duck");
        Console.WriteLine("3. Decoy Duck");
        Console.WriteLine("4. Model Duck");
        Console.WriteLine("5. Rubber Duck");
        

        switch (tipo)
        {
            case 1:
                Console.WriteLine("Excelente decicion tu pato sera Mallard Duck");
                pato[0] = "Mallard Duck"; 
                break;
            case 2:
                Console.WriteLine("Excelente decicion tu pato sera RedHead Duck");
                pato[0] = "RedHead Duck";
                break;
            case 3:
                Console.WriteLine("Excelente decicion tu pato sera Decoy Duck");
                pato[0] = "Decoy Duck";
                break;
            case 4:
                Console.WriteLine("Excelente decicion tu pato sera Model Duck");
                pato[0] = "Model Duck";
                break;
            case 5:
                Console.WriteLine("Excelente decicion tu pato sera Rubber Duck");
                pato[0] = "Rubber Duck";
                break;

            default:
                Console.WriteLine("Favor de seleccionar una de las opciones dentro del rango posible");
                Console.ReadLine();
                tipopatos();
                break;
        }
    }

}

namespace PatternDesignDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck Duckkey = new Duck();

            Duckkey.tipopatos();
            Duckkey.Volar();
            Duckkey.Graznar();
        }
    }
}

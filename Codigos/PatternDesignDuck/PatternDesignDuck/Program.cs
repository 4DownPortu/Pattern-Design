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
    string[] pato = new string[7];

    public void Modificaciones()
    {
        Console.Clear();
        //Menu de modificar
        int desicion;
        Console.WriteLine("Como quieres que tu pato nade? \n (Digite el numero segun lo deseado)");
        Console.WriteLine("1.Rapido");
        Console.WriteLine("2.Lento");
        Console.WriteLine("3.Modo sirena");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:

                Console.WriteLine("Muy bien ahora tu pato puede hacer nadar rapido.");
                pato[5] = "Si";
                pato[6] = "rapido";
                break;

            case 2:

                Console.WriteLine("Muy bien ahora tu pato puede hacer Squeeze.");
                pato[5] = "Si";
                pato[6] = "Lento";
                break;

            case 3:

                Console.WriteLine("Esta bien, supongo que tambien existen patos mudos.");
                pato[5] = "Si";
                pato[6] = "Sirena";
                break;


            default:
                Console.WriteLine("Selecciona unicamente una de las opciones posibles:");
                Console.ReadKey();
                Nadar();
                break;


        }



    }

    public void Reporte()
    {
        Console.Clear();
        //Reporte de cualidades

        Console.WriteLine("REPORTE DE PATO");
        Console.WriteLine("Tipo: " + pato[0]);
        Console.WriteLine("Vuela: " + pato[1]);
        Console.WriteLine("Tipo de vuelo: " + pato[2]);
        Console.WriteLine("Grazna: " + pato[3]);
        Console.WriteLine("Tipo de graznido: " + pato[4]);
        Console.WriteLine("Nada: " + pato[5]);
        Console.WriteLine("Tipo de nado: " + pato[6]);

        Console.WriteLine("\n Presione cualquier tecla para continuar");

        Console.ReadKey();




    }
    public void Nadar()
    {
        Console.Clear();
        //Decicion de si nadara o no.
        int desicion;
        Console.WriteLine("Como quieres que tu pato nade? \n (Digite el numero segun lo deseado)");
        Console.WriteLine("1.Rapido");
        Console.WriteLine("2.Lento");
        Console.WriteLine("3.Modo sirena");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:

                Console.WriteLine("Muy bien ahora tu pato puede hacer nadar rapido.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "rapido";
                break;

            case 2:

                Console.WriteLine("Muy bien ahora tu pato puede hacer Squeeze.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "Lento";
                break;

            case 3:

                Console.WriteLine("Excelente ahora tu pato nada como sirena.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "Sirena";
                break;


            default:
                Console.WriteLine("Selecciona unicamente una de las opciones posibles:");
                Console.ReadKey();
                Console.ReadKey();
                Nadar();
                break;


        }



    }

    public void Graznar ()
    {
        Console.Clear();
        //Decicion de si graznara o no.
        int desicion;
        Console.WriteLine("Como quieres que tu pato grazne? \n (Digite el numero segun lo deseado)");
        Console.WriteLine("1.Quack");
        Console.WriteLine("2.Squeeze");
        Console.WriteLine("3.Mute");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:

                Console.WriteLine("Muy bien ahora tu pato puede hacer Quack." );
                Console.ReadKey();
                pato[3] = "Si";
                pato[4] = "Quack";
                break;

            case 2:

                Console.WriteLine("Muy bien ahora tu pato puede hacer Squeeze.");
                Console.ReadKey();
                pato[3] = "Si";
                pato[4] = "Squeeze";
                break;

            case 3:

                Console.WriteLine("Esta bien, supongo que tambien existen patos mudos.");
                Console.ReadKey();
                pato[3] = "No";
                pato[4] = "Mute";
                break;


            default:
                Console.WriteLine("Selecciona unicamente una de las opciones posibles:");
                Console.ReadKey();
                Graznar();
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
                Console.ReadKey();
                pato[1] = "Si";
                pato[2] = "Alto";
                break;

            case 2:

                Console.WriteLine("Muy bien, ahora tu pato vuela bajo");
                Console.ReadKey();
                pato[1] = "Si";
                pato[2] = "Bajo";
                break;

            case 3:

                Console.WriteLine("Esta bien no todos los patos deben de volar");
                Console.ReadKey();
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
       

        Console.WriteLine("1. Mallard Duck");
        Console.WriteLine("2. RedHead Duck");
        Console.WriteLine("3. Decoy Duck");
        Console.WriteLine("4. Model Duck");
        Console.WriteLine("5. Rubber Duck");

        tipo = Convert.ToInt32(Console.ReadLine());


        switch (tipo)
        {
            case 1:
                Console.WriteLine("Excelente decicion tu pato sera Mallard Duck");
                Console.ReadKey();
                pato[0] = "Mallard Duck"; 
                break;
            case 2:
                Console.WriteLine("Excelente decicion tu pato sera RedHead Duck");
                pato[0] = "RedHead Duck";
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Excelente decicion tu pato sera Decoy Duck");
                pato[0] = "Decoy Duck";
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Excelente decicion tu pato sera Model Duck");
                pato[0] = "Model Duck";
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("Excelente decicion tu pato sera Rubber Duck");
                pato[0] = "Rubber Duck";
                Console.ReadKey();
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
            Duckkey.Nadar();
            Duckkey.Reporte();
        }
    }
}

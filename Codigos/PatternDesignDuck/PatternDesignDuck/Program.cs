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
        Console.WriteLine("Quiere modificar algun comportamiento");
        Console.WriteLine("1.Si");
        Console.WriteLine("2.No");
        desicion = Convert.ToInt32(Console.ReadLine());

        if (desicion== 1)
        {
            Console.Clear();
            int comportamiento;

            Console.WriteLine("Cual comportamiento quiere modificar?");
            Console.WriteLine("1.Vuelo");
            Console.WriteLine("2.Graznar");
            Console.WriteLine("3.Nadar");
            comportamiento = Convert.ToInt32(Console.ReadLine());

            if (comportamiento == 1)
            {
                Volar();
                Modificaciones();

               
            }
            else if (comportamiento == 2)
            {
                Graznar();
                Modificaciones();
            }
            else if (comportamiento == 3)
            {
                Nadar();
                Modificaciones();
            }
            else
            {
                Console.WriteLine("Selecciona unicamente una opcion dentro del rango disponible.");
                Console.ReadKey();
                Modificaciones();

            }
        }
        else if(desicion == 2 )
        {
            int reporte2;
            Console.Clear();
            Console.WriteLine("Excelente entonces tu pato esta listo");
            Console.WriteLine("Quieres visualizar el reporte de nuevo?");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No ");
            reporte2 = Convert.ToInt32(Console.ReadLine());

            if (reporte2 == 1)
            {
                int decision2;
                Console.Clear();
                Reporte();
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Desea realizar otra modificacion?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                decision2 = Convert.ToInt32(Console.ReadLine());

                if (decision2 == 1)
                {
                    Modificaciones();

                }
                else if(decision2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Excelente, buen dia, gracias por utilizar nuestro software.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Selecciona unicamente una opcion dentro del rango disponible\n\nPresiona ENTER para continuar:");
                    Console.ReadKey();
                    Modificaciones();
                }
                
                
            }
            else if(reporte2 == 2)
            {
                Console.Clear();
                Console.WriteLine("Excelente, buen dia, gracias por utilizar nuestro software.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Selecciona unicamente una opcion dentro del rango disponible\n\nPresiona ENTER para continuar:");
                Console.ReadKey();
                Modificaciones();
            }


        }
        else
        {
            Console.Clear();
            Console.WriteLine("Selecciona unicamente una opcion dentro del rango disponible\n\nPresiona ENTER para continuar:");
            Console.ReadKey();
            Modificaciones();
        }
       



    }

    public void Reporte()
    {
        Console.Clear();
        //Reporte de cualidades

        Console.WriteLine("\n\t|REPORTE DE PATO|\n");
        Console.WriteLine("Tipo:----------------" + pato[0]);
        Console.WriteLine("\n");
        Console.WriteLine("Vuela:---------------" + pato[1]);
        Console.WriteLine("Tipo de vuelo:-------" + pato[2]);
        Console.WriteLine("Grazna:--------------" + pato[3]);
        Console.WriteLine("Tipo de graznido:----" + pato[4]);
        Console.WriteLine("Nada:----------------" + pato[5]);
        Console.WriteLine("Tipo de nado:--------" + pato[6]);

        Console.WriteLine("\nPresione ENTER para continuar");

        Console.ReadKey();




    }
    public void Nadar()
    {
        Console.Clear();
        //Decicion de si nadara o no.
        int desicion;
        Console.WriteLine("\n\t-----|¿Como quieres que tu pato nade?|-----\n\t____(Digite el numero segun lo deseado)_____\n");
        Console.WriteLine("1.Rapido");
        Console.WriteLine("2.Lento");
        Console.WriteLine("3.Modo sirena");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Muy bien ahora tu pato puede hacer nadar rapido.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "rapido";
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Muy bien ahora tu pato puede nadar lento.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "Lento";
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Excelente ahora tu pato nada como sirena.");
                Console.ReadKey();
                pato[5] = "Si";
                pato[6] = "Sirena";
                break;


            default:
                Console.Clear();
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
        Console.WriteLine("\n\t-----|¿Como quieres que tu pato grazne?|-----\n\t____(Digite el numero segun lo deseado)____\n");
        Console.WriteLine("1.Quack");
        Console.WriteLine("2.Squeeze");
        Console.WriteLine("3.Mute");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Muy bien ahora tu pato puede hacer Quack." );
                Console.ReadKey();
                pato[3] = "Si";
                pato[4] = "Quack";
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Muy bien ahora tu pato puede hacer Squeeze.");
                Console.ReadKey();
                pato[3] = "Si";
                pato[4] = "Squeeze";
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Esta bien, supongo que tambien existen patos mudos.");
                Console.ReadKey();
                pato[3] = "No";
                pato[4] = "Mute";
                break;


            default:
                Console.Clear();
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
        
        Console.WriteLine("\n\t-----|¿Como quieres que tu pato vuele?|-----\n\t____(Digite el numero segun lo deseado)____\n");
        Console.WriteLine("1.Alto");
        Console.WriteLine("2.Bajo");
        Console.WriteLine("3.No vuela");
        desicion = Convert.ToInt32(Console.ReadLine());

        switch (desicion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Muy bien ahora tu pato puede volar alto");
                Console.ReadKey();
                pato[1] = "Si";
                pato[2] = "Alto";
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Muy bien, ahora tu pato vuela bajo");
                Console.ReadKey();
                pato[1] = "Si";
                pato[2] = "Bajo";
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Esta bien no todos los patos deben de volar");
                Console.ReadKey();
                pato[1] = "No";
                pato[2] = "No vuela";
                break;


            default:
                Console.Clear();
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
        Console.WriteLine("\n\t -----|Seleccione un tipo de pato:|-----\n\t(Digite el numero segun el pato deseado)\n");
       

        Console.WriteLine("1. Mallard Duck");
        Console.WriteLine("2. RedHead Duck");
        Console.WriteLine("3. Decoy Duck");
        Console.WriteLine("4. Model Duck");
        Console.WriteLine("5. Rubber Duck");

        tipo = Convert.ToInt32(Console.ReadLine());


        switch (tipo)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Excelente decision tu pato sera Mallard Duck");
                Console.ReadKey();
                pato[0] = "Mallard Duck"; 
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Excelente decision tu pato sera RedHead Duck");
                pato[0] = "RedHead Duck";
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Excelente decision tu pato sera Decoy Duck");
                pato[0] = "Decoy Duck";
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Excelente decision tu pato sera Model Duck");
                pato[0] = "Model Duck";
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Excelente decision tu pato sera Rubber Duck");
                pato[0] = "Rubber Duck";
                Console.ReadKey();
                break;

            default:
                Console.Clear();
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
            Duckkey.Modificaciones();
        }
    }
}

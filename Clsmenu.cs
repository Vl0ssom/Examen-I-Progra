using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1PrograII
{
    internal class Clsmenu
    {

        public static void mostrarMenu()
        {
            ClsTransacciones clsTransacciones = new ClsTransacciones();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Selecciona una opción: ");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de  Vehículos x Número de Placa");
                Console.WriteLine("4. Modificar Datos Vehículos x Número de Placa");
                Console.WriteLine("5. Reporte Todos los Datos de los Vectores");
                Console.WriteLine("6. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        clsTransacciones.OpcionInicializarVectores();

                        break;
                    case 2:
                        clsTransacciones.Ingresar();

                        break;
                    case 3: 
                        Console.WriteLine("Inserte el número de placa: ");                     
                        string NumPlaca = Console.ReadLine();
                        clsTransacciones.Consultar(NumPlaca);

                        break;
                    case 4:
                        Console.WriteLine("Inserte el número de placa: ");
                        string NumPlaca1 = Console.ReadLine();
                        clsTransacciones.Modificar(NumPlaca1);
                        break;
                    case 5:                      
                        clsTransacciones.Reporte();
                        break;
                    case 6:
                        salir = true;
                        break;
                        return;
                    default:
                        Console.WriteLine("Opcion inválida.");
                        Console.Read();
                        break;
                }
            }
        }





    }
}









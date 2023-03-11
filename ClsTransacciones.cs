using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1PrograII
{
    internal class ClsTransacciones
    {
        private string[] numFacturas = new string[15];
        private string[] numPlacas = new string[15];
        private DateTime[] fechas = new DateTime[15];
        private TimeSpan[] horas = new TimeSpan[15];
        private int[] tipoVehiculo = new int[15];
        private int[] numCasetas = new int[15];
        private double[] montosAPagar = new double[15];
        private double[] pagos = new double[15];
        private double[] vueltos = new double[15];

        public string[] NumFactura { get { return numFacturas; } }
        public string[] NumPlaca { get { return numPlacas; } }
        public DateTime[] Fecha { get { return fechas; } }
        public TimeSpan[] Hora { get { return horas; } }
        public int[] TipoVehiculo { get { return tipoVehiculo; } }
        public int[] NumCaseta { get { return numCasetas; } }
        public double[] MontoPagar { get { return montosAPagar; } }
        public double[] PagaCon { get { return pagos; } }
        public double[] Vuelto { get { return vueltos; } }

        public ClsTransacciones()
        {

        }


        public void Ingresar()
        {
            int i = 0;
            string opcion = "";

            while (opcion != "0")
            {
                Console.Write("Ingrese una opción:");
                Console.WriteLine("1. Ingresar datos de vehículo");
                Console.WriteLine("0. Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (i < 15)
                        {
                            Console.WriteLine("Ingrese el número de factura:");
                            NumFactura[i] = Console.ReadLine();

                            Console.WriteLine("Ingrese el número de placa:");
                            NumPlaca[i] = Console.ReadLine();

                            Console.WriteLine("Ingrese la fecha (dd/mm/aaaa):");
                            Fecha[i] = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                            Console.WriteLine("Ingrese la hora (hh:mm):");
                            Hora[i] = TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm", null);

                            Console.WriteLine("Ingrese el tipo de vehículo (1=Moto, 2=Vehículo Liviano, 3=Camión o Pesado, 4=Autobús):");
                            TipoVehiculo[i] = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el número de caseta (1, 2 o 3):");
                            NumCaseta[i] = int.Parse(Console.ReadLine());

                            switch (TipoVehiculo[i])
                            {
                                case 1:
                                    MontoPagar[i] = 500;
                                    break;
                                case 2:
                                    MontoPagar[i] = 700;
                                    break;
                                case 3:
                                    MontoPagar[i] = 2.700;
                                    break;
                                case 4:
                                    MontoPagar[i] = 3.700;
                                    break;
                            }

                            Console.WriteLine("Ingrese el monto a pagar:");
                            PagaCon[i] = double.Parse(Console.ReadLine());

                            Vuelto[i] = PagaCon[i] - MontoPagar[i];

                            Console.WriteLine("Datos de vehículo ingresados correctamente.");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Se ha alcanzado el límite de vehículos que pueden ser ingresados.");
                        }
                        break;
                    case "0":
                        Console.WriteLine("Volviendo al menú principal");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }

        }

        public void Consultar(string Placa = "")
        {

            for (int i = 0; i < NumPlaca.Length; i++)
            {
                if (NumPlaca[i] == Placa)
                {
                    Console.WriteLine("Datos del vehículo con número de placa {0}:", numPlacas);
                    Console.WriteLine("Número de factura: {0}", numFacturas[i]);
                    Console.WriteLine("Fecha: {0}", fechas[i]);
                    Console.WriteLine("Hora: {0}", horas[i]);
                    Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[i]);
                    Console.WriteLine("Número de caseta: {0}", numCasetas[i]);
                    Console.WriteLine("Monto a pagar: {0}", montosAPagar[i]);
                    Console.WriteLine("Paga con: {0}", PagaCon[i]);
                    Console.WriteLine("Vuelto: {0}", Vuelto[i]);
                    Console.WriteLine("------------------------------------------");
                    return;


                    Console.WriteLine("No se encontró ningún vehículo con número de placa {0}", numPlacas);
                }
            }
        }

        public void Modificar(string Placa = " ")
        {
            for (int i = 0; i < numPlacas.Length; i++)
            {
                if (numPlacas[i] == Placa)
                {
                    Console.WriteLine("Datos del vehículo con número de placa {0}:", numPlacas);
                    Console.WriteLine("Número de factura: {0}", NumFactura[i]);
                    Console.WriteLine("Fecha: {0}", Fecha[i]);
                    Console.WriteLine("Hora: {0}", Hora[i]);
                    Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[i]);
                    Console.WriteLine("Número de caseta: {0}", NumCaseta[i]);
                    Console.WriteLine("Monto a pagar: {0}", MontoPagar[i]);
                    Console.WriteLine("Paga con: {0}", pagos[i]);
                    Console.WriteLine("Vuelto: {0}", vueltos[i]);
                    Console.WriteLine("------------------------------------------");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún vehículo con número de placa {0}", numPlacas);


        }

        public void Reporte(string Placa = "")
        {
            for (int i = 0; i < numPlacas.Length; i++)
            {
                if (numPlacas[i] == Placa)
                {
                    Console.WriteLine("Datos del vehículo con número de placa {0}:", numPlacas);
                    Console.WriteLine("Número de factura: {0}", NumFactura[i]);
                    Console.WriteLine("Fecha: {0}", Fecha[i]);
                    Console.WriteLine("Hora: {0}", Hora[i]);
                    Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[i]);
                    Console.WriteLine("Número de caseta: {0}", NumCaseta[i]);
                    Console.WriteLine("Monto a pagar: {0}", MontoPagar[i]);
                    Console.WriteLine("Paga con: {0}", PagaCon[i]);
                    Console.WriteLine("Vuelto: {0}", Vuelto[i]);
                    Console.WriteLine("------------------------------------------");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún vehículo con número de placa {0}", numPlacas);

        }
        public void OpcionInicializarVectores()
        {
            Console.WriteLine("Vectores inicializados correctamente.");

            Array.Clear(tipoVehiculo, 0, tipoVehiculo.Length);
            Array.Clear(fechas, 0, fechas.Length);
            Array.Clear(horas, 0, horas.Length);
            Array.Clear(numCasetas, 0, numCasetas.Length);
            Array.Clear(montosAPagar, 0, montosAPagar.Length);
            Array.Clear(pagos, 0, pagos.Length);
            Array.Clear(vueltos, 0, vueltos.Length);

            for (int i = 0; i < numPlacas.Length; i++)
            {
                numPlacas[i] = "";
            }
            for (int i = 0; i < numFacturas.Length; i++)
            {
                numFacturas[i] = "";
            }
        }
    }
}

using System;
using System.ComponentModel.Design;

namespace INF_512
{
    class Program
    {
        static void Main(string[] args)
        {
            //Velocidad y Aceleracion de Vehiculo

            VeloYAcelTester();


            //Trapecio

            TrapecioTester();          
            
        }

        private static double CapturaLado()
        {
            double x = double.Parse(Console.ReadLine());
            return x;
        }

        static void VeloYAcelTester()
        {
            //Velocidad y Aceleracion de Vehiculo


            double dis = 0;
            int time = 0;
            try
            {
                Console.WriteLine("Introduzca la distancia (en metros): ");
            
                dis = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el tiempo (en segundos): ");

                time = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("El dato introducido no es un decimal o entero. Error:", ex.Message);
            }

            

            Vehiculo auto = new Vehiculo(dis, time);

            auto.getVelocidad();
            auto.getAceleracion();

            Console.Write("Presione cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        static void TrapecioTester()
        {
            //Trapecio

            int opcion = 0;
            double a, b, c, d, h;

            while (opcion != 3)
            {
                new Trapecio().MostrarMenu();
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Clear();
                    new Trapecio().DibujarTrapecio();

                    Console.WriteLine("Entre el lado A: ");
                    a = CapturaLado();
                    Console.WriteLine("Entre el lado B: ");
                    b = CapturaLado();
                    Console.WriteLine("Entre el lado C: ");
                    c = CapturaLado();
                    Console.WriteLine("Entre el lado D: ");
                    d = CapturaLado();


                    Trapecio t1 = new Trapecio(a, b, c, d);
                    Console.WriteLine(t1.CalcularPerimetro());
                    Console.Write("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    new Trapecio().DibujarTrapecio();

                    Console.WriteLine("Entre el lado A: ");
                    a = CapturaLado();
                    Console.WriteLine("Entre el lado B: ");
                    b = CapturaLado();
                    Console.WriteLine("Entre altura H: ");
                    h = CapturaLado();

                    Trapecio t2 = new Trapecio(a, b, h);
                    Console.WriteLine(t2.CalcularArea());
                    Console.Write("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}

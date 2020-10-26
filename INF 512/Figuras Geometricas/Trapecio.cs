using System;
using System.Collections.Generic;
using System.Text;

namespace INF_512.Figuras_Geometricas
{
    class Trapecio : Cuadrilatero, IFGeometricas
    {
        //Propiedades Auto Implementadas (campos o atributos implicitos)

        public double A
        { get; set; }
        public double B
        { get; set; }
        public double C
        { get; set; }
        public double D
        { get; set; }
        public double H
        { get; set; }

        //Constructores

        public Trapecio(int lados) : base(lados)
        {

        }

        public Trapecio(double a, double b, double c, double d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        //Constructor que se llama cuando no se conoce la altura
        public Trapecio(double a, double b, double h)
        {
            this.A = a;
            this.B = b;
            this.H = h;
        }

        //Metodos

        public override void MostrarForma()
        {
            Console.WriteLine("         B    ");
            Console.WriteLine("     __________");
            Console.WriteLine("    /|          \\");
            Console.WriteLine(" C / |           \\ D");
            Console.WriteLine("  /  |H           \\");
            Console.WriteLine(" /___|_____________\\");
            Console.WriteLine("          A         ");
        }
        
        public override double CalcularPerimetro()
        {
            Console.Write("\nEl Perimetro es: ");
            return A + B + C + D;
            
        }
        
        public override double CalcularArea()
        {
            
            Console.Write("El Area es: ");
            return (A + B) / 2 * H;
           
        }

        public void MostrarMenu()
        {
            Console.WriteLine("\n¿Qué desea calcular con el Trapecio?");
            Console.WriteLine("\n1. Perimetro");
            Console.WriteLine("2. Area");
            Console.WriteLine("3. Salir");
        }
    }
}

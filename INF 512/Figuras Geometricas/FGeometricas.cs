using System;
using System.Collections.Generic;
using System.Text;

namespace INF_512.Figuras_Geometricas
{
    abstract class FGeometricas
    {

        //Propiedades
        public int Lados
        { get; }
        public string Nombre
        { get; }
        public double Perimetro
        { get; protected set; }
        public double Area
        { get; protected set; }
        //Constructor
        public FGeometricas(int lados)
        {
            Lados = lados;
            switch(Lados)
            {
                case 3:
                    Nombre = "Triangulo";
                    break;
                case 4:
                    Nombre = "Cuadrilatero";
                    break;
                case 5:
                    Nombre = "Pentagono";
                    break;
                default:
                    Nombre = "Figura Desconocida";
                    break;
            }
            
        }
        //Metodos

        /*
         * public abstract double CalcularPerimetro();
        public abstract double aa();

        public abstract void MostrarForma();
        */
        
        public  virtual void Definir()
        {
            Console.WriteLine("Esto es una Figura Geométrica");

        }
    }
}

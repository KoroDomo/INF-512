using System;
using System.Collections.Generic;
using System.Text;

namespace INF_512
{
    class Vehiculo
    {
        /*
         * Clase para calcular Velocidad y Aceleracion de un Vehiculo 
         */

        //Atributos o Campos
        //Se puede omitir su expresion explicita, utilizando Propiedades Auto Implementadas de la forma:
        /*
         * public double Distancia
         * { get; set; }
         */
        private double distancia;
        private int tiempo;

        //Constructor sin Parametros

        public Vehiculo()
        {
            Distancia = 0;
            Tiempo = 0;
        }

        //Constructor con Parametros
        public Vehiculo(double d, int t)
        {
            this.Distancia = d;
            this.Tiempo = t;            
        }

        //Propiedades
        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public double Velocidad
        { get; private set; }

        //Métodos
        public void getVelocidad()
        {
            Velocidad = Distancia / Tiempo;
            Console.WriteLine($"Velocidad = {Velocidad} m/s");
        }

        public void getAceleracion()
        {
            Console.WriteLine($"Aceleración = {Velocidad / Tiempo} m/s^2"); 
        }

        public void mostrarEnunciado()
        {
            Console.WriteLine("Calcular Velocidad y Aceleracion de Vehículo");
        }
    }
}

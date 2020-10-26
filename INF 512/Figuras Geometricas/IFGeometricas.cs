using System;
using System.Collections.Generic;
using System.Text;

namespace INF_512.Figuras_Geometricas
{
    interface IFGeometricas
    {
        int Lados
        { get; }
        string Nombre
        { get; }
        double Perimetro
        { get; }
        double Area
        { get; }

        double CalcularPerimetro();
        double CalcularArea();
        void MostrarForma();
        void Definir();

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace INF_512.Figuras_Geometricas
{
    class Triangulo : FGeometricas
    {
        public Triangulo(int lados) : base(lados)
        {

        }

        public override void Definir()
        {
            Console.WriteLine($"Esto es un {Nombre}");

        }
    }
}

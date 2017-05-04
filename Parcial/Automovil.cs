using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Automovil : Vehiculo, IActivo
    {
        public int NumPuertas { get; set; }
        public int Modelo { get; set; }

        public Automovil(String n, String m, int p, int np, int mod):base(n,m,p) {

            NumPuertas = np;
            Modelo = mod;

        }

        public override string ToString()
        {
            return base.ToString() + " Num Puertas: " + NumPuertas + " Modelo: " + Modelo;
        }

        public int precio()
        {
            return Precio;
        }
    }
}

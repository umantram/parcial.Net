using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Vehiculo
    {

        public String Nombre { get; set; }
        public String Marca { get; set; }
        public int Precio { get; set; }

        public Vehiculo(String n, String m, int p) {

            Nombre = n;
            Marca = m;
            Precio = p;

        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Marca: " + Marca + " Precio: " + Precio;
        }


    }
}

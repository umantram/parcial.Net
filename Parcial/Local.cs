using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Local: IActivo
    {

        public String Direccion { get; set; }
        public String Categoria { get; set; }
        public int Precio { get; set; }

        public Local(String D, String C, int P) {

            Direccion = D;
            Categoria = C;
            Precio = P;
            
        }

        public int precio()
        {
            return Precio;
        }

        public override string ToString()
        {
            return "Direccion: " + Direccion + " Categoria: " + Categoria + " Precio: " + Precio;
        }

    }
}

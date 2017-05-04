using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Avion: Vehiculo
    {

        private int NumAsientos { get; set; }
        private String Categoria { get; set; }


        public Avion(String n, String m, int p, int na, String cat):base(n,m,p){

            Nombre = n;
            Marca = m;
            Precio = p;

            NumAsientos = na;
            Categoria = cat;
            
        }

 

        public override string ToString()
        {
            return  base.ToString() + " Asientos : " + NumAsientos + " Categoria : " + Categoria.ToString();
        }

    }
}

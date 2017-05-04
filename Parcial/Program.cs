using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IActivo> vehiculos = new List<IActivo>();
            ArrayList vehiculos2 = new ArrayList();

            
            Automovil auto1 = new Automovil("Auto1", "Marca1", 1, 1, 11);
            Automovil auto2 = new Automovil("Auto2", "Marca2", 2, 2, 22);
            Automovil auto3 = new Automovil("Auto3", "Marca3", 3, 3, 33);

            Local local1 = new Local("Direcc1", "Cat1", 1);
            Local local2 = new Local("Direcc2", "Cat2", 2);

            vehiculos.Add(auto1);
            vehiculos.Add(auto2);
            vehiculos.Add(auto3);
            vehiculos.Add(local1);
            vehiculos.Add(local2);

            vehiculos2.Add(auto1);
            vehiculos2.Add(auto2);
            vehiculos2.Add(auto3);
            vehiculos2.Add(local1);
            vehiculos2.Add(local2);


            int suma = 0;

            foreach (IActivo vehi in vehiculos)
            {
                Console.WriteLine("la lista {0}", vehi.ToString());
                suma += vehi.precio();
    
            }

            foreach (IActivo vehi in vehiculos2)
            {
                Console.WriteLine("la lista {0}", vehi.ToString());
                suma += vehi.precio();

            }
            Console.WriteLine("Suma {0}", suma);
            
            Avion avion = new Avion("a", "b", 1, 2, "c");
            Console.WriteLine("el Avion {0}", avion.ToString());
            
            int[] arreglo = new int[5] { 4, 5, 8, 9, 3 };

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("arreglo: {0}", arreglo[i]);

            }

            int[,] matriz = new int[3,3];

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    matriz[i, j] = rnd.Next(1,10);

                }
            }

            
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine("arreglo: {0}", matriz[i,j]);

                }

                Console.WriteLine("---");

            }


            
            Console.ReadKey();


        }
    }
}

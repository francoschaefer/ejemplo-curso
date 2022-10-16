using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo v1 = new Vehiculo();
            //Vehiculo v2 = new Vehiculo();
            //Vehiculo v3 = new Vehiculo();

            //v1.Color = "Rojo";
            //v2.Color = "Azul";
            //v3.Color = "Verde";

            //List<Vehiculo> Listavehiculos = new List<Vehiculo>();
            //Listavehiculos.Add(v1);
            //Listavehiculos.Add(v2);
            //Listavehiculos.Add(v3);

            //Console.WriteLine("La cantidad de vehiculos es de " + Listavehiculos.Count);
            //Console.WriteLine("El color del vehiculo 1 es " + v1.Color);
            //Console.WriteLine("El color del vehiculo 2 es " + v2.Color);
            //Console.WriteLine("El color del vehiculo 3 es " + v3.Color);

            Auto a1 = new Auto();
            Console.WriteLine(a1.Motor.Encender());
            
            Console.ReadKey();
        }
    }
}

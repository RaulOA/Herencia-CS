using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vehiculo
    {
        // Variables de instancia protegidas
        protected string marca;
        protected string modelo;

        // Constructor de la clase base
        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public void Arrancar()
        {
            Console.WriteLine($"{marca} {modelo} arrancó");
            Console.ReadKey();
        }
        public void Detener()
        {
            Console.WriteLine($"{marca} {modelo} se detuvo");
            Console.ReadKey();
        }
    }
}

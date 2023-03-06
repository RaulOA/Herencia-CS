using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Auto : Vehiculo
    {
        // Variable de instancia adicional
        private int year;

        // Constructor de la clase derivada
        public Auto(string marca, string modelo, int year) : base(marca, modelo)
        {
            this.year = year;
        }
        public void Acelerar()
        {
            Console.WriteLine($"{marca} {modelo} {year} está acelerando");
            Console.ReadKey();
        }
        public void Frenar()
        {
            Console.WriteLine($"{marca} {modelo} {year} está frenando");
            Console.ReadKey();
        }
    }
}

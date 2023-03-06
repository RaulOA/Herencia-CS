using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Ford", "Mustang", 2022);
            miAuto.Arrancar();
            miAuto.Acelerar();
            miAuto.Frenar();
            miAuto.Detener();
        }
    }
}

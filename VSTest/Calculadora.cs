using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTest
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Suma()
        {
            return Numero1 + Numero2;
        }
        public int Resta()
        {
            return Numero1 - Numero2;
        }

    }
}

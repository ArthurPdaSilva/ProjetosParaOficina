using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public float NumberOne { get; set; }
        public float NumberTwo { get; set; }

        public Calculadora(float n1, float n2)
        {
            NumberOne = n1;
            NumberTwo = n2;
        }

        public float Somar()
        {
            return NumberOne + NumberTwo;
        }

        public float Diminuir()
        {
            return NumberOne - NumberTwo;
        }

        public float Multiplicar()
        {
            return NumberOne * NumberTwo;
        }

        public float Dividir()
        {
            return NumberOne / NumberTwo;
        }
    }
}

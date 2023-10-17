using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        private float _numberOne;
        private float _numberTwo;

        public void AdicionarNumeros(float n1, float n2)
        {
            _numberOne = n1;
            _numberTwo = n2;
        }

        public float Somar()
        {
            return _numberOne + _numberTwo;
        }

        public float Diminuir()
        {
            return _numberOne - _numberTwo;
        }

        public float Multiplicar()
        {
            return _numberOne * _numberTwo;
        }

        public float Dividir()
        {
            return _numberOne / _numberTwo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEstadisticaPOO
{
    internal class Calculadora
    {
        public List<double> listaNumeros { get; set; }

        public Calculadora(List<double> listaNumeros)
        {
            this.listaNumeros = listaNumeros;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//principio de responsabilidad unica
namespace CalculadoraEstadisticaPOO
{

    //es una clase que imita una aplicaicon
    //puede recibir distintas listas
    internal class Calculadora
    {
        public List<double> listaNumeros { get; set; }
        //la lista es accesible desde cualquier punto, aunque es inecesaria...
        public Calculadora(List<double> numberList)
        {
            listaNumeros = new List<double>();
        }
        public void ImprimirMenu()
        {
            Console.WriteLine("Calculadora Estadistica");
            Console.WriteLine("[1] Ingresar numeros a la lista");
            Console.WriteLine("[2] Calcular la media");
            Console.WriteLine("[3] Calcular la mediana");
            Console.WriteLine("[4] Calcular la moda");
            Console.WriteLine("[5] Calcular la desviacion estandar");
            Console.WriteLine("[6] Finalizar programa");
            Console.Write("Ingrese una opcion: ");
        }
        public void LlenarLista()
        {
            try
            {
                listaNumeros.Clear();
                double entradaNumero;
                Console.Write("Ingrese el tamaño de los datos que desea llenar: ");
                
                int tamaño = Convert.ToInt32(Console.ReadLine());
                if (tamaño <= 0) 
                {
                    Console.WriteLine("No puede ingresar un tamaño negativo.");
                    return;
                }
                for (int i = 0; i < tamaño; i++)
                {
                    Console.Write($"Ingrese el numero en la posicion ({i + 1}): ");
                    entradaNumero = Convert.ToDouble(Console.ReadLine());
                    listaNumeros.Add(entradaNumero);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, vuelva a intentarlo: "+ex);
                Console.ReadLine();
            }
        }
        public void ImprimirLista()
        {
            Console.WriteLine("Lista de numeros: ");
            Console.Write("\t[  ");
            foreach (var i in listaNumeros)
            {
                Console.Write(i + "  ");
            }
            Console.Write("]\n\n");
        }
        static double resultado = 0;
        public double Media()
        {
            double sumaNumeros = 0;
            foreach (int i in listaNumeros)
            {
                sumaNumeros += i;
            }
            double resultado = (sumaNumeros / listaNumeros.Count);
            return resultado;
        }

        public double Mediana()
        {
            listaNumeros.Sort();
            int puntoMedio = listaNumeros.Count / 2;

            if (listaNumeros.Count % 2 == 0)
            {
                resultado = (listaNumeros[puntoMedio] + listaNumeros[puntoMedio - 1]) / 2;
                return resultado;
            }
            else
            {
                return resultado = listaNumeros[puntoMedio];
            }
        }

        public void Moda()
        {
            Dictionary<double, int> frecuencias = new Dictionary<double, int>();

            foreach (double num in listaNumeros)
            {
                if (frecuencias.ContainsKey(num))
                {
                    frecuencias[num]++;
                }
                else
                {
                    frecuencias[num] = 1;
                }
            }

            int maxFrecuencia = frecuencias.Values.Max();
            double moda = frecuencias.First(x => x.Value == maxFrecuencia).Key;

            Console.WriteLine("La moda es: " + moda);
        }

        public double DesviacionEstandar()
        {
            double media = Media();
            double sumaDesviaciones = 0;
            foreach (int i in listaNumeros)
            {
                double diferencia = i - media;
                sumaDesviaciones += Math.Pow(diferencia, 2);
            }
            double varianza = (sumaDesviaciones / listaNumeros.Count);
            return resultado = Math.Round(Math.Sqrt(varianza), 6);
        }
    }
}

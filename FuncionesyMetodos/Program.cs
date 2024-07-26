using System;
using System.Reflection.Metadata.Ecma335;

namespace CalculadoraEstadistica 
{
    internal class Program 
    { 
        static List<double> ListaNumeros = new List<double>();
        static double numero;
        static double resultado;
        static int num;
        static void Main(string[] args) {
            int opcion;
            do 
            {
                ImprimirMenu();
                switch (opcion = LlenarNumeroEntero()) 
                {
                case 1:
                    Console.WriteLine();
                    LlenarLista();
                    break;
                case 2:
                    ImprimirLista();
                    Media();
                    Console.WriteLine("El resultado de la media es: "+ resultado);
                    Console.WriteLine();
                        break;
                case 3:
                    Mediana();
                    break;
                case 4:
                    break; 
                case 5:
                    break;
                case 6:
                    ImprimirLista();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("> > > Opcion Invalida");
                    break;
                }
                
            } while (opcion != 5);
        }

        static void ImprimirMenu()
        {
            Console.WriteLine("Calculadora Estadistica");
            Console.WriteLine("[1] Ingresar numeros a la lista");
            Console.WriteLine("[2] Calcular la media");
            Console.WriteLine("[3] Calcular la mediana");
            Console.WriteLine("[4] Calcular la desviacion estandar");
            Console.WriteLine("[5] Finalizar programa");
            Console.WriteLine("[6] Imprimir lista");
            Console.Write("Ingrese una opcion: ");
        }
        static void LlenarLista() 
        {
            //Se limpia la lista
            ListaNumeros.Clear();

            Console.Write("Ingrese el tamaño de los datos que desea llenar: ");
            double tamaño = LlenarNumero();  
            
                for (int i = 0 ; i < tamaño ; i++) 
                {
                    Console.Write($"Ingrese el numero en la posicion ({i + 1}): ");
                    double a = LlenarNumero();
                    ListaNumeros.Add(a);
                }
            
            Console.WriteLine();
        }

        static void ImprimirLista() 
        {
            Console.WriteLine("\nLista de numeros: ");
            Console.Write("\t\t");
                foreach (int i in ListaNumeros) {
                    Console.Write(i + " ");
                }
            Console.WriteLine("\n");
        }

        static double Media()
        {
            double sumaNumeros = 0;
            foreach (int i in ListaNumeros)
            {

                sumaNumeros += i;
            }
            Console.WriteLine(sumaNumeros);
            resultado = (sumaNumeros / ListaNumeros.Count);
            return resultado;
        }

        static void Mediana() 
        {
            ListaNumeros.Sort();
            ImprimirLista();
            int puntoMedio = ListaNumeros.Count / 2;

            if (ListaNumeros.Count % 2 == 0)
            {
                double medianaLista = (ListaNumeros[puntoMedio] + ListaNumeros[puntoMedio-1]) / 2;
                Console.WriteLine("La media para la lista es: "+ medianaLista);
            }
            else 
            {
                Console.WriteLine("La media para la lista es: " + ListaNumeros[puntoMedio]);
            }
        }
        static void Moda()
        { 

        }

        static double LlenarNumero()
        {//Llenar numero
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numero = Convert.ToDouble(Console.ReadLine());
                    //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                    valido = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numero;
        }
        static int LlenarNumeroEntero()
        {//Llenar numero
            bool valido = false;
            while (!valido)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                    valido = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return num;
        }


    }
}

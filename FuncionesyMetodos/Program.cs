using System;
using System.Reflection.Metadata.Ecma335;

namespace CalculadoraEstadistica 
{
    internal class Program 
    { 
        static List<int> ListaNumeros = new List<int>();
        static int numero;
        static int resultado = 0;
        static void Main(string[] arg) {
            int opcion;
            do 
            {
                ImprimirMenu();
                switch (opcion = LlenarNumero()) 
                {
                case 1:
                    Console.WriteLine();
                    LlenarLista();
                    break;
                case 2:
                    
                    break;
                case 3:
                    break;
                case 4:
                    break; 
                case 5:
                    break;
                case 6:
                    MostrarLista();
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
            int tamaño = LlenarNumero();  
            
                for (int i = 0 ; i < tamaño ; i++) 
                {
                    Console.Write($"Ingrese el numero en la posicion ({i + 1}): ");
                    int numero = LlenarNumero();
                    ListaNumeros.Add(numero);
                }

            Console.WriteLine();
        }

        static void MostrarLista() 
        {
            Console.WriteLine("\nLista de numeros: ");
                foreach (int i in ListaNumeros) {
                    Console.Write(i + " ");
                }
            Console.WriteLine("\n");
        }
        static int LlenarNumero()
        {//Llenar numero
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
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



    }
}

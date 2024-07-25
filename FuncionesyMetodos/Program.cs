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
                switch (opcion = PedirNumero()) 
                {
                case 1:
                    Console.WriteLine("Opcion 1 uwu");                        
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break; 
                case 5:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(">>>Opcion Invalida");
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
            Console.Write("Ingrese una opcion: ");
        }
        static int PedirNumero() 
        {
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
                    Console.WriteLine("Error no puede ingresar letras. Intente de nuevo: " + ex);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Error desconocido: " + ex);
                }
            }
            return numero;
        }
        

    }
}

using CalculadoraEstadisticaPOO;
using static System.Runtime.InteropServices.JavaScript.JSType;

double resultado;

        List<double> ListaNumeros = new List<double>();
        Calculadora calculadora = new Calculadora(ListaNumeros);
        int opcion;
        do
        {
            calculadora.ImprimirMenu();
            switch (opcion = LlenarNumeroEntero())
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("[1] Ingresar numeros a la lista");
                    calculadora.LlenarLista();
                    calculadora.ImprimirLista();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("[2] Calcular la media");
                    calculadora.ImprimirLista();
                    resultado = calculadora.Media();
                    Console.WriteLine("El resultado de la media es: " + resultado);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("[3] Calcular la mediana");
                    calculadora.ImprimirLista();
                    resultado = calculadora.Mediana();
                    Console.WriteLine("La mediana para la lista es: " + resultado);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("[4] Calcular la moda");
                    calculadora.ImprimirLista();
                    calculadora.Moda();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("[5] Calcular la desviacion estandar");
                    calculadora.ImprimirLista();
                    resultado = calculadora.DesviacionEstandar();
                    Console.WriteLine("La desviacion estandar es: " + resultado);
                    Console.WriteLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("[!] Opcion Invalida");
                    break;
            }

        } while (opcion != 6);
        Console.WriteLine("Justo Geovanny Alcon Mendoza, 1578324");
        Console.ReadLine();
    static int LlenarNumeroEntero()
    {//Llenar numero
    int numeroEntero = 0;
    bool valido = false;
        while (!valido)
        {
            try
            {
            numeroEntero = Convert.ToInt32(Console.ReadLine());
                //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("[!] Error no puede ingresar letras...");
                Console.Write("Intente de nuevo: ");
            }
            catch (Exception)
            {
                Console.WriteLine("[!] Error desconocido... ");
                Console.Write("> Intente de nuevo: ");
            }
        }
        return numeroEntero;
    }


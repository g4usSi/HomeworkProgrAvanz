using System;
using System.ComponentModel;

public class Producto
{
    public List<string> Nombre { get; set; } = new List<string>();
    public List<int> Año { get; set; } = new List<int>();
    public List<double> Tamaño { get; set; } = new List<double>();
    public List<string> Tipo { get; set; } = new List<string>();
    public void MostrarLista()
    {
        for (int i = 0 ; i < Año.Count ; i++)
        {
            Console.WriteLine($"\t\tProducto #{i}");
            Console.WriteLine($"Nombre: {Nombre[i]}");
            Console.WriteLine($"Producto: {Tipo[i]}");
            Console.WriteLine($"Año: {Año[i]}");
            Console.WriteLine($"Tamaño: {Tamaño[i]}");
        }
    }
    public void AgregarProducto(string nombre, int año, double tamaño, string tipo) 
    {
        Nombre.Add(nombre);
        Año.Add(año);
        Tamaño.Add(tamaño);
        Tipo.Add(tipo);
    }
    public int BuscarProducto(string nombreIngresado)
    {
        int posicion = Nombre.IndexOf(nombreIngresado);
        return posicion;
    }
    public void MostrarProducto(int posicion)
    {
        if (posicion >= 0)
        {
            Console.WriteLine($"\t\tProducto #{(posicion + 1)}");
            Console.WriteLine($"Nombre: {Nombre[posicion]}");
            Console.WriteLine($"Producto: {Tipo[posicion]}");
            Console.WriteLine($"Año: {Año[posicion]}");
            Console.WriteLine($"Tamaño: {Tamaño[posicion]}");
        }
    }
    public int LlenarNumeroEntero()
    {
        int numeroEntero = 0;
        bool valido = false;
        while (!valido)
        {
            try
            {
                numeroEntero = Convert.ToInt32(Console.ReadLine());
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



}
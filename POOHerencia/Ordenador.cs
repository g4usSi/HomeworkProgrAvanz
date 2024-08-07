using System;

public class Ordenador:Producto
{
    public List<string> TarjetaGrafica { get; set; }
    public void AgregarOrdenador()
    {
        Console.WriteLine("\t\tProducto #" + (Año.Count + 1));
        Console.Write($"Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write($"Año ");
        int año = LlenarNumeroEntero();
        Console.Write($"Tamaño:");
        double tamaño = Convert.ToDouble(Console.ReadLine());
        AgregarProducto(nombre, año, tamaño, "Ordenador");
    }
}

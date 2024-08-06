using System;

public class Ordenador:Producto
{
    public void AgregarOrdenador()
    {
        Console.WriteLine("\t\tProducto #" + (Año.Count + 1));
        Console.Write($"Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write($"Año ");
        int año = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Tamaño:");
        double tamaño = Convert.ToDouble(Console.ReadLine());
        AgregarProducto(nombre, año, tamaño, "Ordenador");
    }
}

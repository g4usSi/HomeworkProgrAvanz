using System;

public class Telefono : Producto
{
    public void AgregarTelefono()
    {
        Console.WriteLine("\t\tProducto #" + (Nombre.Count + 1));
        Console.Write($"Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write($"Año ");
        int año = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Tamaño:");
        double tamaño = Convert.ToDouble(Console.ReadLine());
        AgregarProducto(nombre, año, tamaño, "Telefono");
    }
}

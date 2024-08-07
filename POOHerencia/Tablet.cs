using System;

public class Tablet : Producto
{
    public int Marca { get; set; }
    public new void AgregarTablet()
    {
        Console.WriteLine("\t\tProducto #" + (Año.Count + 1));
        Console.Write($"Nombre: ");
            string nombre = Console.ReadLine();
        Console.WriteLine($"Año ");
            int año = LlenarNumeroEntero();
        Console.Write($"Tamaño:");
            double tamaño = Convert.ToDouble(Console.ReadLine());
        AgregarProducto(nombre, año, tamaño, "Tablet");
    }

}

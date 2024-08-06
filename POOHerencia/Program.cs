using static System.Runtime.InteropServices.JavaScript.JSType;
Telefono telefono = new Telefono();
Ordenador ordenador = new Ordenador();
Tablet tablet = new Tablet();

List<Producto> productos = new List<Producto>();
int opcion;

do
{
    Menu();
    Console.Write("Ingrese una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Submenu();
            Console.Write("Ingrese una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) 
            {
                case 1:
                    telefono.AgregarTelefono();
                    break;
                case 2:
                    ordenador.AgregarOrdenador();
                    break;
                case 3:
                    tablet.AgregarTablet();
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                break;
            }
            Console.Clear();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Listar todos los productos");
            telefono.MostrarLista();
            ordenador.MostrarLista();
            tablet.MostrarLista();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Buscar producto");
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Buscar(nombre, telefono, ordenador, tablet);
            break;
        default:
            Console.WriteLine("Opcion Invalida...");
        break; 
    }

} while (opcion != 4);
static void Menu() 
{
    Console.WriteLine("... Gestor de productos electronicos ...");
    Console.WriteLine("1. Agregar nuevos productos");
    Console.WriteLine("2. Listar todos los productos");
    Console.WriteLine("3. Buscar producto");
    Console.WriteLine("4. Salir");
}
static void Submenu() 
{
    Console.WriteLine("Ingrese el tipo de producto a agregar...");
    Console.WriteLine("1. Telefono");
    Console.WriteLine("2. Ordenador");
    Console.WriteLine("3. Tablet");
}
static void Buscar(string nombre, Telefono telefono, Ordenador ordenador, Tablet tablet) 
{
    telefono.MostrarProducto(telefono.BuscarProducto(nombre));
    ordenador.MostrarProducto(ordenador.BuscarProducto(nombre));
    tablet.MostrarProducto(tablet.BuscarProducto(nombre));
}

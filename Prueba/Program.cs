using Prueba;
using System.Linq;

List<Provincia> Provincias = new List<Provincia>();
void CargarDatos()
{
    do
    {


    Provincia provincia = new Provincia();
    Console.WriteLine("Ingrese el nombre de la provincia ");
    provincia.Nombre = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(provincia.Nombre))
    {
        Console.WriteLine("Finalizando la carga de provincias...");
        break;
    }
    Console.WriteLine("Ingrese el gobernador");
    provincia.Gobernador = Console.ReadLine();
    Console.WriteLine("Ingrese la region");
    provincia.Region = Console.ReadLine();
        provincia.ciudades = new List<Ciudad>();

        while (true)
        {
            Ciudad ciudad = new Ciudad();
            Console.WriteLine("Ingrese el nombre de la ciudad ");
            ciudad.Nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ciudad.Nombre))
            {
                Console.WriteLine("Finalizando la carga de ciudades...");
                break;
            }
            Console.WriteLine("Ingrese la capacidad de habitantes");
            ciudad.CantidadDeHabitantes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la superficie en km²");
            ciudad.Superficie = int.Parse (Console.ReadLine());
            provincia.ciudades.Add(ciudad);
        }
        Provincias.Add(provincia);

    } while (true);
}


void ReporteDeDatos()
{
    foreach (var DatoProvincias in Provincias)
    {
        Console.WriteLine($"Provincia: ");
        Console.WriteLine($"  Nombre:{DatoProvincias.Nombre}");
        Console.WriteLine($"  Gobernador: {DatoProvincias.Gobernador}");
        Console.WriteLine($"  Region: {DatoProvincias.Region}");
     foreach (var DatoCiudades in DatoProvincias.ciudades)
     {
        Console.WriteLine($"  Ciudades:  ");
        Console.WriteLine($"    Ciudad: {DatoCiudades.Nombre}");
        Console.WriteLine($"    Habitantes: {DatoCiudades.CantidadDeHabitantes}");
        Console.WriteLine($"    Superficie: {DatoCiudades.Superficie} km²");
      }
    }

}

void Estadisticas()
{
    foreach (var EstadisticaProvincias in Provincias)
    {
        for (int EstadisticaHabitantes = 0; EstadisticaHabitantes <; EstadisticaHabitantes++)
        {

        }
    }

}

Console.WriteLine("Saludos. Este es un programa donde puedes cargar Provincias, sus datos como el nombre el gobernador y su region");
Console.WriteLine("Ademas, puedes cargar ciudades las cuales tienen su respectos datos que podras visualizar una vez hayas cargado.");
Console.WriteLine("¿Te interesa? No tiene eleccion igual. Presiona una tecla para continuar.");
Console.ReadKey();
Console.Clear();
CargarDatos();
Console.WriteLine("Genial ya lo has cargado. Presiona una tecla para poder visualizar el reporte de datos.");
Console.Clear();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
ReporteDeDatos();
Console.WriteLine("Geniales datos no? Tambien existen un resumen estadistico donde podes ver cosas como la ciudad con mas habitantes");
Console.WriteLine("Te interesa verlo? Presiona una tecla para visualizar el resumen estadistico");
Console.ReadKey();
Console.Clear();
Estadisticas();
Console.ReadKey();
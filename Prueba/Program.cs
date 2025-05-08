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

void EstadisticasHabitantesCiudad()
{
    Ciudad ciudadConMasHabitantes = null;

    foreach (var provincia in Provincias)
    {
        foreach (var ciudad in provincia.ciudades)
        {
            if (ciudadConMasHabitantes == null || ciudad.CantidadDeHabitantes > ciudadConMasHabitantes.CantidadDeHabitantes)
            {
                ciudadConMasHabitantes = ciudad;
            }
        }
    }

    if (ciudadConMasHabitantes != null)
    {
        Console.WriteLine($"La ciudad con más habitantes es: {ciudadConMasHabitantes.Nombre} con {ciudadConMasHabitantes.CantidadDeHabitantes} habitantes.");
    }

}
void EstadisticasSuperficieCiudad()
{
    Ciudad CiudadConMasSuperficie = null;

    foreach (var provincia in Provincias)
    {
        foreach (var ciudad in provincia.ciudades)
        {
            if (CiudadConMasSuperficie == null || ciudad.Superficie > CiudadConMasSuperficie.Superficie)
            {
                CiudadConMasSuperficie = ciudad;
            }
        }
    }

    if (CiudadConMasSuperficie != null)
    {
        Console.WriteLine($"La ciudad con más superficie es: {CiudadConMasSuperficie.Nombre} con {CiudadConMasSuperficie.Superficie} km².");
    }

}

void EstadisticaHabitantesProvicia()
{
    Provincia ProvinciaConMasHabitantes = null;
    int maxHabitantes = 0;

    foreach (var provincia in Provincias)
    {
        int sumaHabitantes = provincia.ciudades.Sum(ciudad => ciudad.CantidadDeHabitantes);
        if (ProvinciaConMasHabitantes == null || sumaHabitantes > maxHabitantes)
        {
            ProvinciaConMasHabitantes = provincia;
            maxHabitantes = sumaHabitantes;
        }
    }

    if (ProvinciaConMasHabitantes != null)
    {
        Console.WriteLine($"La provincia con más habitantes es: {ProvinciaConMasHabitantes.Nombre} con {maxHabitantes} habitantes.");
    }
}

void EstadisticasSuperficieProvincia()
{
    Provincia ProvinciaConMasSuperficie = null;
    int maxSuperficie = 0;

    foreach (var provincia in Provincias)
    {
        int sumaSuperficies = provincia.ciudades.Sum(ciudad => ciudad.Superficie);
        if (ProvinciaConMasSuperficie == null || sumaSuperficies > maxSuperficie)
        {
            ProvinciaConMasSuperficie = provincia;
            maxSuperficie = sumaSuperficies;
        }
    }

    if (ProvinciaConMasSuperficie != null)
    {
        Console.WriteLine($"La provincia con más superficie es: {ProvinciaConMasSuperficie.Nombre} con {maxSuperficie} habitantes.");
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
EstadisticasHabitantesCiudad();
EstadisticasSuperficieCiudad();
EstadisticaHabitantesProvicia();
EstadisticasSuperficieProvincia();
Console.ReadKey();
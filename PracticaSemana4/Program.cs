using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Mostrar();
        }
    }
}

class Menu
{
    public void Mostrar()
    {
        
        Cliente cliente = new Cliente();
        Bebida bebida = new Bebida();
        Empleado empleado = new Empleado();

        
        Console.Write("Ingrese su nombre: ");
        cliente.Nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        cliente.Edad = int.Parse(Console.ReadLine());

       
        if (cliente.Edad < 18)
        {
            Console.WriteLine("Lo siento, no se pueden vender bebidas alcohólicas a menores de edad.");
            return;
        }

        Console.WriteLine("Menú de bebidas:");
        Console.WriteLine("1. Vodka con jugo");
        Console.WriteLine("2. Martini");
        Console.WriteLine("3. Jarrito");
        Console.WriteLine("4. Cerveza");
        Console.WriteLine("5. Ron con gaseosa");
        Console.WriteLine("6. Vino tinto");
        Console.WriteLine("7. Gaseosa");

        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

       
        switch (opcion)
        {
            case 1:
                bebida.Categoria = "Vodka con jugo";
                break;
            case 2:
                bebida.Categoria = "Martini";
                break;
            case 3:
                bebida.Categoria = "Jarrito";
                break;
            case 4:
                bebida.Categoria = "Cerveza";
                break;
            case 5:
                bebida.Categoria = "Ron con gaseosa";
                break;
            case 6:
                bebida.Categoria = "Vino tinto";
                break;
            case 7:
                bebida.Categoria = "Gaseosa";
                break;
            default:
                Console.WriteLine("Selección no válida.");
                return;
        }


        cliente.Caracteristicas = "Nombre:"+cliente.Nombre;
        empleado.Caracteristicas = "Antendido por bartender";


        bebida.TipoPreparacion = "Servido en vaso con hielo";
        

        Console.WriteLine("Preparando una {0} para:", bebida.Categoria);
        Console.WriteLine("- {0}", cliente.Caracteristicas);
        Console.WriteLine("- {0}", empleado.Caracteristicas);
        Console.WriteLine("- {0}", bebida.TipoPreparacion);
    }
}

class Cliente
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Caracteristicas { get; set; }
}

class Bebida
{
    public string Categoria { get; set; }
    public string TipoPreparacion { get; set; }
}

class Empleado
{
    public string Caracteristicas { get; set; }
}
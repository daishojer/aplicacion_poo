using System;
using System.Collections.Generic;
using System.Linq; // buscar lista mas facil

namespace Biblioteca
{
    class Program
    {
        
        static List<MaterialBiblioteca> biblioteca = new List<MaterialBiblioteca>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
                Console.WriteLine("1. Registrar Material");
                Console.WriteLine("2. Ver todos los materiales");
                Console.WriteLine("3. Prestar Material");
                Console.WriteLine("4. Devolver Material");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RegistrarMaterial();
                        break;
                    case "2":
                        MostrarMateriales();
                        break;
                    case "3":
                        GestionarPrestamo(true); // true = prestar
                        break;
                    case "4":
                        GestionarPrestamo(false); // false = devolver
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void RegistrarMaterial()
        {
            Console.WriteLine("\n--- Registrar Nuevo Material ---");
            Console.Write("Ingrese el Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el Autor: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Tipo de material: (1) Libro Físico, (2) Libro Digital");
            string tipo = Console.ReadLine();

            if (tipo == "1")
            {
                Console.Write("Ingrese el Número de Ejemplar: ");
                if (int.TryParse(Console.ReadLine(), out int ejemplar))
                {
                    
                    biblioteca.Add(new LibroFisico(titulo, autor, ejemplar));
                    Console.WriteLine("¡Libro Físico registrado!");
                }
                else Console.WriteLine("Error: El número de ejemplar debe ser numérico.");
            }
            else if (tipo == "2")
            {
                Console.Write("Ingrese el Tamaño del Archivo (MB): ");
                if (double.TryParse(Console.ReadLine(), out double tamano))
                {
                    
                    biblioteca.Add(new LibroDigital(titulo, autor, tamano));
                    Console.WriteLine("¡Libro Digital registrado!");
                }
                else Console.WriteLine("Error: El tamaño debe ser un número.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        static void MostrarMateriales()
        {
            Console.WriteLine("\n--- Catálogo de la Biblioteca ---");
            if (biblioteca.Count == 0)
            {
                Console.WriteLine("No hay materiales registrados.");
            }
            else
            {
                foreach (var material in biblioteca)
                {
                    // llamar metodo mostrar
                    material.MostrarInformacion(); 
                }
            }
        }

        static void GestionarPrestamo(bool esPrestamo)
        {
            string accion = esPrestamo ? "Prestar" : "Devolver";
            Console.WriteLine($"\n--- {accion} Material ---");
            Console.Write("Ingrese el CÓDIGO del material: ");
            string codigo = Console.ReadLine();

            
            MaterialBiblioteca material = biblioteca.FirstOrDefault(m => m.Codigo == codigo);

            if (material != null)
            {
                if (esPrestamo)
                    material.Prestar(); 
                else
                    material.Devolver();
            }
            else
            {
                Console.WriteLine("Material no encontrado. Verifique el código.");
            }
        }
    }
}
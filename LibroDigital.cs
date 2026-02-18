using System;

namespace Biblioteca
{
    public class LibroDigital : MaterialBiblioteca
    {
        // tamaño libro
        public double TamanoArchivoMB { get; private set; }

        // Constructor
        public LibroDigital(string titulo, string autor, double tamanoMB) 
            : base(titulo, autor)
        {
            TamanoArchivoMB = tamanoMB;
        }

        // Prestar para la regla de 3 días
        public override void Prestar()
        {
             if (EstaPrestado)
            {
                Console.WriteLine($"El libro digital '{Titulo}' ya está prestado.");
                return;
            }

            base.Prestar();
            Console.WriteLine(">> Este libro digital expira en 3 días.");
        }

        //
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo: Libro Digital");
            Console.WriteLine($"Tamaño de Archivo: {TamanoArchivoMB} MB");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
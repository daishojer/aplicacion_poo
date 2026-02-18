using System;

namespace Biblioteca
{
    public class LibroFisico : MaterialBiblioteca
    {
        //Número de ejemplar
        public int NumeroDeEjemplar { get; private set; }

        public LibroFisico(string titulo, string autor, int numeroDeEjemplar) 
            : base(titulo, autor)
        {
            NumeroDeEjemplar = numeroDeEjemplar;
        }
        public override void Prestar()
        {
            // Primero verificamos si ya está prestado usando la lógica del padre
            if (EstaPrestado)
            {
                Console.WriteLine($"El libro físico '{Titulo}' ya está prestado.");
                return;
            }

            // Llamamos a la lógica base para cambiar el estado a "Prestado"
            base.Prestar();
            Console.WriteLine(">> Este libro físico se debe devolver en un máximo de 7 días.");
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); // Muestra título, autor, código...
            Console.WriteLine($"Tipo: Libro Físico");
            Console.WriteLine($"Número de Ejemplar: {NumeroDeEjemplar}");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
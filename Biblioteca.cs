using System;

namespace Biblioteca
{
    // Clase abstracta para cumplir con la rúbrica de Abstracción
    public abstract class MaterialBiblioteca
    {
        // Propiedades con Encapsulamiento 
        public string Titulo { get; protected set; }
        public string Autor { get; protected set; }
        public string Codigo { get; private set; }
        public bool EstaPrestado { get; private set; } // true = Prestado, false = Disponible

        // Constructor
        public MaterialBiblioteca(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            EstaPrestado = false; // Por defecto está disponible
            Codigo = GenerarCodigoUnico();
        }

        // Método para generar el código de 8 caracteres alfanuméricos
        private string GenerarCodigoUnico()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] codigoArray = new char[8];

            for (int i = 0; i < codigoArray.Length; i++)
            {
                codigoArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(codigoArray);
        }

        // Método para Prestar
        public virtual void Prestar()
        {
            if (EstaPrestado)
            {
                Console.WriteLine($"El material '{Titulo}' ya está prestado.");
            }
            else
            {
                EstaPrestado = true;
                Console.WriteLine($"Material '{Titulo}' prestado exitosamente.");
            }
        }

        // Método para Devolver
        public virtual void Devolver()
        {
            if (!EstaPrestado)
            {
                Console.WriteLine($"El material '{Titulo}' ya estaba disponible.");
            }
            else
            {
                EstaPrestado = false;
                Console.WriteLine($"Material '{Titulo}' devuelto exitosamente.");
            }
        }

        // Método para mostrar info 
        public virtual void MostrarInformacion()
        {
            string estado = EstaPrestado ? "Prestado" : "Disponible";
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor:  {Autor}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}
using System;
using System.IO;
namespace A133590.Ejercicio49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 49");
            Console.WriteLine("Programa que crea un archivo de texto con la cadena 'Hola mundo'");
            string nombreArchivo = "holamundo.txt";
            if(!File.Exists(nombreArchivo))
            {
                using(StreamWriter sw = File.CreateText(nombreArchivo))
                {
                    sw.WriteLine("Hola mundo");
                    Console.WriteLine("Archivo creado exitosamente.");
                }
            }
            else
            {
                Console.WriteLine($"Ya existe un archivo llamado: {nombreArchivo}");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;

namespace GUIA_PRACTICA_11
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresar los datos");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente:");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Numero telefonico del cliente:");
                string telCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento del cliente:");
                string nacimientoCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Sueldo del cliente:");
                decimal sueldoCliente = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombreCliente);
                binario.Write(telCliente);
                binario.Write(nacimientoCliente);
                binario.Write(sueldoCliente);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("LOS DATOS SE ALMACENARON...");
                Console.ReadKey();


            }
            catch (Exception)
            {

                Console.WriteLine("sucedio un error al ingresar los datos");
            }
        }
    }
}

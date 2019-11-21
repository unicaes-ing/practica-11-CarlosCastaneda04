using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GUIA_PRACTICA_11
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nCliente = binario.ReadString();
                string tCliente = binario.ReadString();
                string naCliente = binario.ReadString();
                decimal sCliente = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("Datos del cliente");
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente: {0}",nCliente);
                Console.WriteLine();
                Console.WriteLine("Numero de telefono del cliente: {0}", tCliente);
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento del cliente: {0}", naCliente);
                Console.WriteLine();
                Console.WriteLine("Sueldo del cliente: {0:C2}", sCliente);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("presione ENTER para salir");
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("HA OCURRIDO UN ERROR AL QUERER MOSTRAR LOS DATOS");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteServicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //paso1 crear una instacia del proxy WCF
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();

            //paso 2 realizar las llamadas a las operaciones del servicio
            int numero1 = 23;
            int numero2 = 5;
            Console.WriteLine($"Ejemplo de conexión a un servicio Web local.");
            Console.WriteLine($"Dirección: {cliente.Endpoint.Address}");
            Console.WriteLine($"\n\n*** Estado delservicio: {cliente.State}***\n\n");

            // OperacionSUMA

            int resultado = cliente.SumaDosEnteros(numero1, numero2);
            Console.WriteLine($"\nElresultado de la operación Suma Dos Enteros: ({numero1},{numero2}) es: {resultado}");

            // OperacionRESTA
            int resultado1 = cliente.RestaDosEnteros(numero1, numero2);
            Console.WriteLine($"\nElresultado de la operación resta Dos Enteros: ({numero1},{numero2}) es: {resultado1}");

            // OperacionMULTIPLICACION
            int resultado2 = cliente.MultiplicaDosEnteros(numero1, numero2);
            Console.WriteLine($"\nElresultado de la operación multiplica DosEnteros: ({numero1},{numero2}) es: {resultado2}");

            // OperacionDIVICION
            double resultado3 = cliente.DivideDosEnteros(numero1, numero2);
            Console.WriteLine($"\nElresultado de la operación divide Dos Enteros: ({numero1},{numero2}) es: {resultado3}");

            Console.WriteLine("el resultadode la operacion tipoCompuestoCliente() = {0}", cliente.State);

            //paso 4 cerrando el cliente , se cierra la conexion y limpa los recursos 
            cliente.Close();

        }
    }
}

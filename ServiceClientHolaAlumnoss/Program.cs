using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientHolaAlumnoss
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso1 crear una instacia del proxy WCF
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Cliente();

            //paso 2 realizar las llamadas a las operaciones del servicio
            String resultado = cliente.GetData(5);
            Console.WriteLine("el resultado de la operacion get(5) = {0}", resultado);

            // llamada a la operacion compisiteType()
            ServiceReference1.CompositeType TipoCompuestoCLiente = new ServiceReference1.CompositeType()
            {
                BoolValue = true,
                StringValue = "mi cadena cliente"
            };
            ServiceReference1.CompositeType TipoCompuestoResultado = cliente.GetDataUsingDataContract(TipoCompuestoCLiente);
            Console.WriteLine("el resultadode la operacion tipoCompuestoCliente() = {0}", TipoCompuestoResultado.StringValue);

            //paso 4 cerrando el cliente , se cierra la conexion y limpa los recursos 
            cliente.Close();
       
        }
    }
}

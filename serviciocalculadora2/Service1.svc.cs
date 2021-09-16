using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace serviciocalculadora2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public int SumaDosEnteros(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int RestaDosEnteros(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int MultiplicaDosEnteros(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public double DivideDosEnteros(double valor1, double valor2)
        {
            return valor1 / valor2;
        }



        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

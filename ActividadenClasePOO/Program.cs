using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadenClasePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa dos numeros"); //Pedir al usuario que ingrese dos numeros
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Operacion.Calculadora calculadora = new Operacion.Calculadora(); //Crear la instancia de la clase Calculadora
            Console.WriteLine("Suma: " + calculadora.Suma(a, b)); //Llamar a los metodos de la clase Calculadora
            Console.WriteLine("Resta: " + calculadora.Resta(a, b));
            Console.WriteLine("Multiplicacion: " + calculadora.Multiplicacion(a, b));
            Console.WriteLine("Division: " + calculadora.Division(a, b));
            Console.ReadKey();
        }
    }
}

namespace Operacion //Crear un namespace llamado Operacion
{
    public class Calculadora //Crear una clase llamada Calculadora
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }
        public int Resta(int a, int b)
        {
            return a - b;
        }
        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }

}
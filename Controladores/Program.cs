using Ejercicio2Condicionales.Servicios;

namespace Ejercicio2Condicionales
{
    class Program
    {
        /// <summary>
        /// Método principal de nuestra aplicación
        /// 231023 - MDN
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            //Instanciamos la clase donde se encuentran nuestros métodos
            NumeroInterfaz ni = new NumeroImplementacion();

            //Declaramos las variables
            int num1, num2;
            num1 = ni.pedirNumero();
            num2 = (int)Math.Sqrt(num1);

            //Realizamos la comprobación para ver si el número introducido tiene raiz cuadrada perfecta
            if (num2 * num2 == num1)
            {
                Console.WriteLine("El número {0} se puede expresar como el cuadrado de otro número", num1);
            }
            else
            {
                Console.WriteLine("El número {0} no se puede expresar como el cuadrado de otro número", num1);
            }

            
        }
    }
}

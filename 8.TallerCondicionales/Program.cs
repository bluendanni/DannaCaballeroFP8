using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args) 
        {
           /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en  pantalla los números de menor a mayor. Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben ingresar números diferentes.*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 != num2)
            {
                //Verdadero
                mayor = num1 > num2
                  ? (num1 > num3 ? num1 : num3)
                  : (num2 > num3 ? num2 : num3);
                Console.WriteLine($"El número mayor es: {mayor}");
            }
            else
            {
                //Falso
                Console.WriteLine($"Ingrese números diferentes entre sí");
            }

            if (num2 != num3)
            {
                //Verdadero
                mayor = num2 > num3
                  ? (num1 > num3 ? num1 : num3)
                  : (num2 > num3 ? num2 : num3);

            }
            else
            {
                //Falso\
            }
            if (num1 != num3)
            {
                //Verdadero
                mayor = num1 > num3
                  ? (num1 > num3 ? num1 : num3)
                  : (num2 > num3 ? num2 : num3);
           
            }
            else
            {
                //Falso\
            }

            //Orden de mayor a menor
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Número mayor: {num1}");
            }
            else if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"Número menor: {num1}");
;           }
            else if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"Número del medio: {num1}");
            }

            if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"Número mayor: {num2}");
            }
            else if (num2 < num3 && num2 < num1)
            {
                Console.WriteLine($"Número menor: {num2}");
                
            }
            else if (num2 < num3 && num2 > num1)
            {
                Console.WriteLine($"Número del medio: {num2}");
                
            }

            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"Número mayor: {num3}");
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine($"Número menor: {num3}");
            }
            else if (num3 < num1 && num3 > num2)
            {
                Console.WriteLine($"Número del medio: {num3}");
            }

        }
    }
}

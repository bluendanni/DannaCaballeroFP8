using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
El algoritmo debe escribir en pantalla: 
La cantidad de números introducidos que son mayores que 0 
La cantidad de números introducidos menores que 0  
La cantidad de números iguales a 0. */
            {
                int cantidad, contador = 0;
                int mayores = 0, menores = 0, ceros = 0;

                Console.Write("¿Cuántos números deseas ingresar?");
                cantidad = int.Parse(Console.ReadLine());

                while (contador < cantidad)
                {
                    Console.Write("Ingresa un número: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero > 0)
                    {
                        mayores++;
                    }
                    else if (numero < 0)
                    {
                        menores++;
                    }
                    else
                    {
                        ceros++;
                    }

                    contador++;
                }

                Console.WriteLine("\nResultados:");
                Console.WriteLine("Números mayores que 0: " + mayores);
                Console.WriteLine("Números menores que 0: " + menores);
                Console.WriteLine("Números iguales a 0: " + ceros);
            }

        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;
namespace _22.Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que permita calcular el promedio de calificaciones.
            float numero = 0;
            float contador = 0;
            string respuesta = "si";

            while (respuesta == "si")
            {
                Console.WriteLine("Ingrese una calificación: ");
                float calificacion = float.Parse(Console.ReadLine());

                numero += calificacion;
                contador++;

                Console.WriteLine("¿Desea ingresar otra calificación? (si/no)");
                respuesta = Console.ReadLine().ToLower();
            }

            if (contador > 0)
            {
                double promedio = numero / contador;
                Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }

            // Algoritmo para mostrar los divisores de un número ingresado por teclado.
            Console.WriteLine("Ingrese un número para encontrar sus divisores: ");
            int numeroDivisor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores de {numeroDivisor} son:");
            for (int numerito = 1; numerito <= numeroDivisor; numerito++)
            {
                if (numeroDivisor % numerito == 0)
                {
                    Console.WriteLine(numerito);
                }
                
            }
        }
    }
}
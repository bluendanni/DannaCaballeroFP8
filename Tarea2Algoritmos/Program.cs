namespace Tarea2Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();


            int edad = 0;
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web, {nombre}");
            }
            else
            {
                Console.WriteLine($"A mimir!");
            }

            Console.WriteLine("Ingresa Numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa Numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + numero2);
                Console.WriteLine(numero1 - numero2);
            }

            else
            {
                Console.WriteLine(numero1 * numero2);
                Console.WriteLine(numero1 / numero2);
            }



        }
    }
}

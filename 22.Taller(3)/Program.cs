namespace _22.Taller_3_
{
    internal class Program
    {
        static void Main()
        {
            while (true) // Bucle infinito, salimos con break cuando el usuario diga 'n'
            {
                Console.Write("Ingrese la base (o 'n' para salir): ");
                string entradaBase = Console.ReadLine();

                // Si el usuario ingresa 'n', terminamos el programa
                if (entradaBase.ToLower() == "n")
                {
                    Console.WriteLine("Programa finalizado.");
                    break;
                }

                // Convertimos la base a entero
                int b;
                if (!int.TryParse(entradaBase, out b))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                Console.Write("Ingrese el exponente: ");
                string entradaExp = Console.ReadLine();

                // Permitimos salir en este punto también si el usuario ingresa 'n'
                if (entradaExp.ToLower() == "n")
                {
                    Console.WriteLine("Programa finalizado.");
                    break;
                }

                int e;
                if (!int.TryParse(entradaExp, out e))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                // Calculamos la potencia manualmente
                long resultado = 1;
                for (int i = 0; i < e; i++)
                {
                    resultado *= b;
                }

                Console.WriteLine($"{b}^{e} = {resultado}");
            }
        }
    }
}

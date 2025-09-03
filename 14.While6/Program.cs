namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.*/

            Console.WriteLine("Ingrese un número límite (n): ");
            int n = int.Parse(Console.ReadLine());
            int contador = 1;
            int pares = 0;

            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    pares++;
                }
                contador++;
            }
            Console.WriteLine("Entre 1 y " + n + " hay " + pares + " números pares ");
        }
    }
}

namespace _29.TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
          pantalla la suma de los elementos de cada columna. */

            int[,] numeros = new int[4, 4];
            int[] sumaColumnas = new int[numeros.GetLength(1)];
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {   
                    Console.WriteLine($"Ingrese el valor para la posición [{i},{j}]: ");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i, j]} |");
                }
                Console.WriteLine();
            }
            // Recorrer la matriz para sumar los elementos de cada comlumna
            for (int i = 0; i < numeros.GetLength(1); i++)
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    sumaColumnas[i] += numeros[j, i];
                }
            }
            //Recorrer el vector y mostrar la suma de cada columna
            for (int i =0; i < sumaColumnas.Length; i++)
            {
                Console.Write($"{sumaColumnas[i]} |");
            }

        }
    }
}

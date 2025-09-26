namespace _27.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];
            string[,] nombres = new string[2, 3]; //Rango = 6
            char[,] caracter = new char[3, 2]; //Rango = 6                                  

            ///Asignacion de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            //numeros[1, 2] = 2; Error: fuera de rango.
            // Otra forma de declara e inicializar una matriz
            string[,] apellidos =
            {
                {"Caballero","Hernández" },
                {"Alfaro", "Ríos"},
                {"López", "Arias"}
            };
            //Recuperar datos de una matriz
            Console.WriteLine(apellidos[1,1]);
            //Recorrer Matrices - Almacenar datos
            char[,] caracteres = new char[3, 2]; //Rango = 6

            for (int i = 0; i < 2; i++) //Recorre filas
            {
                for (int j = 0; j < 2; j++)//Recorre columnas de cada fila
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion con indices [{i},{j}]");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }
            //Recorrer Matrices - Recuperar datos
            for (int i = 0; i < caracteres.GetLength(0); i++) ///.GetLength(0) devuelve numero de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) // .GetLength(1) devuelve numero de columnas
                {
                    Console.Write($"Caracter posición [{i}, {j}]:{caracteres[i,j]}");
                }   
            }

            for (int i = 0; i < caracteres.GetLength(0); i++) ///.GetLength(0) devuelve numero de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) // .GetLength(1) devuelve numero de columnas
                {
                Console.Write($"{caracteres[i, j]} |");
                }
            Console.WriteLine();
            }
            //Rango de la matriz
            Console.WriteLine(caracteres.Length);

            //Crear una matriz de 4x4 y llenarla con el número 10
            int[,] matrizDiez = new int[4, 4];
            for (int i = 0; i < matrizDiez.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDiez.GetLength(1); j++)
                {
                    matrizDiez[i, j] = 10;
                    Console.Write($"{matrizDiez[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

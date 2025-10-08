namespace Parcial3Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Implemente un programa que permita al usuario definir, llenar y operar sobre una matriz de números enteros de dimensiones arbitrarias, con las siguientes funcionalidades y restricciones
             Manipulación y operaciones con matrices dinámicas
             Implemente un programa que permita al usuario definir, llenar y operar sobre una matriz de números enteros de dimensiones arbitrarias, con las siguientes funcionalidades y restricciones:
             Requisitos:
             Ingreso robusto de dimensiones:
             Solicite al usuario ingresar el número de filas n y columnas m para la matriz.
             Ambas dimensiones deben ser enteros positivos mayores o iguales a 2 y menores o iguales a 10.
             Si el usuario ingresa un valor inválido, el programa debe mostrar un mensaje de error y volver a solicitar la dimensión.
             Carga dinámica y validación de elementos:
             El usuario debe ingresar cada elemento de la matriz, indicando claramente la posición (fila, columna).
             Cada valor debe ser un número entero dentro del rango (-1000, 1000). Si el número ingresado no cumple esta condición, se debe pedir nuevamente.
             Visualización formateada:
             Mostrar la matriz en pantalla, con filas y columnas numeradas para facilitar la identificación de posiciones.
             Menú de operaciones avanzadas:
             Presentar un menú con las siguientes opciones:
             Sumar
             Restar
             Multiplicar
             Dividir
             Selección y validación de operandos:
             Para cada operación, solicite al usuario ingresar las posiciones (fila, columna) de los dos operandos dentro de la matriz.
             Verifique que las posiciones estén dentro de los límites de la matriz.
             En caso de división, si el segundo operando es cero, solicite una nueva posición válida hasta que no sea cero.
             Ejecución y reporte de resultados:
             Realice la operación seleccionada con los dos números.
             Muestre en pantalla la expresión matemática completa, incluyendo los valores y el resultado.
             Ciclo continuo:
             Tras realizar una operación, el programa debe preguntar si el usuario desea realizar otra operación con la misma matriz.
             En caso afirmativo, repetir el proceso de selección y operación.
             En caso negativo, finalizar el programa. */

            int n, m;
            do
            {
                Console.Write("Ingrese el número de filas (2-10): ");
                n = int.Parse(Console.ReadLine());
                if (n < 2 || n > 10)
                {
                    Console.WriteLine("Error: el número de filas debe estar entre 2 y 10.\n");
                }
            } while (n < 2 || n > 10);

            do
            {
                Console.Write("Ingrese el número de columnas (2-10): ");
                m = int.Parse(Console.ReadLine());
                if (m < 2 || m > 10)
                {
                    Console.WriteLine("Error: el número de columnas debe estar entre 2 y 10.\n");
                }
            } while (m < 2 || m > 10);

            int[,] matriz = new int[n, m];

            Console.WriteLine("\n--- Ingreso de elementos de la matriz ---");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int valor;
                    bool valido;
                    do
                    {
                        Console.Write($"Ingrese el valor para la posición [{i + 1},{j + 1}] (-1000 a 1000): ");
                        valido = int.TryParse(Console.ReadLine(), out valor) && valor >= -1000 && valor <= 1000;
                        if (!valido)
                        {
                            Console.WriteLine("Error: el valor debe ser un número entero entre -1000 y 1000.");
                        }
                    } while (!valido);

                    matriz[i, j] = valor;
                }
            }

            Console.WriteLine("\n ¡Matriz Ingresada!");
            Console.Write("     ");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"[{j + 1,4}]");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"[{i + 1,2}] ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }
                Console.WriteLine();
            }

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n Menú de operaciones ");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");

                int opcion;
                do
                {
                    Console.Write("Seleccione una opción (1-5): ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Error: opción inválida.");
                    }
                } while (opcion < 1 || opcion > 5);

                if (opcion == 5)
                {
                    Console.WriteLine("\n Fin. ¡Hasta luego! :D ");
                    break;
                }

                Console.WriteLine("\n Selección de operandos");
                int fila1, col1, fila2, col2;

                do
                {
                    Console.Write($"Fila del primer número (1-{n}): ");
                    fila1 = int.Parse(Console.ReadLine());
                } while (fila1 < 1 || fila1 > n);

                do
                {
                    Console.Write($"Columna del primer número (1-{m}): ");
                    col1 = int.Parse(Console.ReadLine());
                } while (col1 < 1 || col1 > m);

                do
                {
                    Console.Write($"Fila del segundo número (1-{n}): ");
                    fila2 = int.Parse(Console.ReadLine());
                } while (fila2 < 1 || fila2 > n);

                do
                {
                    Console.Write($"Columna del segundo número (1-{m}): ");
                    col2 = int.Parse(Console.ReadLine());
                } while (col2 < 1 || col2 > m);

                int num1 = matriz[fila1 - 1, col1 - 1];
                int num2 = matriz[fila2 - 1, col2 - 1];

                double resultado = 0;

                if (opcion == 4)
                {
                    while (num2 == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero. Ingrese una nueva posición para el segundo número.");
                        do
                        {
                            Console.Write($"Fila del segundo número (1-{n}): ");
                            fila2 = int.Parse(Console.ReadLine());
                        } while (fila2 < 1 || fila2 > n);

                        do
                        {
                            Console.Write($"Columna del segundo número (1-{m}): ");
                            col2 = int.Parse(Console.ReadLine());
                        } while (col2 < 1 || col2 > m);

                        num2 = matriz[fila2 - 1, col2 - 1];
                    }
                }

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado: {num1} × {num2} = {resultado}");
                        break;
                    case 4:
                        resultado = (double)num1 / num2;
                        Console.WriteLine($"\nResultado: {num1} ÷ {num2} = {resultado:F3}");
                        break;
                }

                Console.Write("\n¿Desea realizar otra operación con la misma matriz? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                continuar = (respuesta == "s");
                Console.WriteLine();
                Console.WriteLine($"Gracias por usar el programa, ¡hasta luego!");

            }
        
        }
    }

}

namespace _8.Taller_ejercicio3_
{
    using System;

    class Program
    {
        static void Main()
        {
            //Ingresar coordenadas
            Console.WriteLine("Ingrese coordenadas de P1:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese coordenadas de P2:");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese coordenadas de P3:");
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // Calcular distancias entre puntos
            double d1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)); // P1-P2
            double d2 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2)); // P2-P3
            double d3 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1)); // P1-P3

            Console.WriteLine($"\nDistancia P1-P2: {d1}");
            Console.WriteLine($"Distancia P2-P3: {d2}");
            Console.WriteLine($"Distancia P1-P3: {d3}");

            // Condiciones del triángulo
            bool cond1 = d1 + d2 > d3;
            bool cond2 = d1 + d3 > d2;
            bool cond3 = d2 + d3 > d1;

            Console.WriteLine();
            if (cond1 && cond2 && cond3)
            {
                Console.WriteLine("✅ Sí se puede formar un triángulo.");
            }
            else
            {
                Console.WriteLine("❌ No se puede formar un triángulo. Fallaron estas condiciones:");
                if (!cond1) Console.WriteLine($"- d1 + d2 no es mayor que d3");
                if (!cond2) Console.WriteLine($"- d1 + d3 no es mayor que d2");
                if (!cond3) Console.WriteLine($"- d2 + d3 no es mayor que d1");
            }
        }
    }
}

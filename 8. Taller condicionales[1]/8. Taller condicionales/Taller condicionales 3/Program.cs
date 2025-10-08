namespace Taller_condicionales_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la coordenada x del primer punto");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada y del primer punto");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada x del segundo punto");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada y del segundo punto");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada x del tercer punto");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada y del tercer punto");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Double distancia1;
            Double distancia2;  
            Double distancia3;

            distancia1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            distancia2 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
            distancia3 = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));

            Console.WriteLine($"la distancia entre los puntos 1 y 2 es {distancia1}");
            Console.WriteLine($"la distancia entre los puntos 2 y 3 es {distancia2}");
            Console.WriteLine($"la distancia entre los puntos 1 y 3 es {distancia3}");

            Double triangulo;

            triangulo = (0.5 * (Math.Abs ((x1*(y2-y3)) + (x2*(y3-y1) + (x3*(y1-y2))))));

            if (triangulo > 0)
            {
                Console.WriteLine("Los puntos ingresados forman un triángulo entre si");
            }
            else
            {
                Console.WriteLine("Los puntos ingresados estan alineados y no forman un triangulo entre si");
            }
        }
    }
}

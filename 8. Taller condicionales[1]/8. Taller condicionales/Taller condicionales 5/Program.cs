using System.Timers;

namespace Taller_condicionales_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vidas;
            Random rnd = new Random();
            vidas = rnd.Next(1,6);
            Console.WriteLine($"Tu personaje tiene {vidas} vidas");

            if (vidas > 0)
            {
                Console.WriteLine("Presiona c, x, t o i para realizar una acción");
                char accion = Convert.ToChar(Console.ReadLine());

                switch (accion)
                {
                    case 'c':
                        Console.WriteLine("El personaje esta disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje esta hablando con la rana");
                        break;
                    case 't':
                        Console.WriteLine("El pesonaje esta en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es invencible");
                        break;
                    default:
                        Console.WriteLine("Presione otra tecla");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no tiene vidas y no puede realizar ninguna acción");
            }

            
        }
    }
}

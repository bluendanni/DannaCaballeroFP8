namespace Taller_condicionales_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mueve tu personaje");
            char direccion = Convert.ToChar(Console.ReadLine());

            switch (direccion)
            {
            case 'a':
                    Console.WriteLine("El personaje se mueve a la izquierda");
                    break;
            case 'd':
                    Console.WriteLine("El personaje se mueve a la derecha");
                    break;
            default:
                    Console.WriteLine("El personaje no se puede mover en otra direccion");
                    break;

            }
                



           

        }
    }
}

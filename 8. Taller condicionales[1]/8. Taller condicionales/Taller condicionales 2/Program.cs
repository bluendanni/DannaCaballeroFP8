using System.Globalization;

namespace Taller_condicionales_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random rnd = new Random();
            numero= rnd.Next(1, 6);
            Console.WriteLine(numero);

            Console.WriteLine("¿El personaje esta en estado invencible?\n0- No\n1- Si");
            bool invencible = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));



            if ((invencible == true) && (numero >= 1) && (numero <= 10))
            {
                Console.WriteLine("El personaje esta disparando");
            }
            else
            {
                Console.WriteLine("no estoy haciendo nada");
            }
                    
       

        }   
    }
}

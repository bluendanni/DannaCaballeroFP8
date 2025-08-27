namespace _8.Taller__ejercicio_2_
{
    class Program
    {
        static void Main()
        {
            //Ingresar si el personaje está en estado invencible
            Console.WriteLine("¿El personaje está en estado invencible? (True/False): ");
            bool invencible = Convert.ToBoolean(Console.ReadLine());

            if (invencible )
            {
                Console.WriteLine("¿Cuánta munición tiene?");
            }

                //Generar munición aleatoria con Random
                Random rnd = new Random();
            int municion = rnd.Next(0, 21); // Genera entre 0 y 20
            Console.WriteLine($"Cantidad de munición: {municion}");
            

            // Condición pedida
            if (invencible && municion >= 1 && municion <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }
            //Si no cumple, no se hace nada
        }
    }
}
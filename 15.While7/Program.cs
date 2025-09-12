namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidadesvariables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.

            double ahorroTotal = 0;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.Write("Ingresa la cantidad que vas a depositar en el mes " + mes + ": "); 
                double deposito = double.Parse(Console.ReadLine());

                ahorroTotal += deposito;

                Console.WriteLine("Llevas ahorrado hasta el mes " + mes + ": " + ahorroTotal);
            }

            Console.WriteLine("\nEl ahorro total en el año es: " + ahorroTotal);
        }
    }
}

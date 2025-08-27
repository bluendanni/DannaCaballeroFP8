namespace Parcial1DannaCaballero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa en C# que permita determinar el elemento zodiacal de una persona,
             en función de su mes de nacimiento y signo zodiacal */

            string mes = "";
            Console.WriteLine("Ingrese su mes de nacimiento");
            mes = Console.ReadLine();


            string signo = "";
            Console.WriteLine("Ingrese su signo zodiacal");
            signo = Console.ReadLine();

            if ((mes == "marzo" || mes == "abril" || mes == "julio" || mes == "agosto" || mes == "noviembre" || mes == "diciembre")
                && (signo == "aries" || signo == "leo" || signo == "sagitario"))
            {
                Console.WriteLine("Su elemento es fuego");
            }
            else if ((mes == "abril" || mes == "mayo" || mes == "agosto" || mes == "septiembre" || mes == "diciembre" || mes == "enero")
                && (signo == "tauro" || signo == "virgo" || signo == "capricornio"))
            {
                Console.WriteLine("Su elemento es tierra");
            }
            else if ((mes == "mayo" || mes == "junio" || mes == "septiembre" || mes == "octubre" || mes == "enero" || mes == "febrero")
                && (signo == "géminis" || signo == "libra" || signo == "acuario"))
            {
                Console.WriteLine("Su elemento es aire");
            }
            else if ((mes == "marzo" || mes == "junio" || mes == "julio" || mes == "octubre" || mes == "noviembre" || mes == "febrero")
                && (signo == "cáncer" || signo == "escorpión" || signo == "piscis"))
            {
                Console.WriteLine("Su elemento es agua");
            }
            else
            {
                Console.WriteLine("Los datos no coinciden con ninguna categoría");
            }
        }
        
    }
}

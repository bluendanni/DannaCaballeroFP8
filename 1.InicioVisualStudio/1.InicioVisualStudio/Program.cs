namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            string nombre = "Danna";
            const string iva = "19%";
            string apellidos = "Caballero Hernández";
            Console.Write(nombre + " Bienvenido al curso de programación\n");
            nombre = "Michelle";
            //iva = "20%"; No puedo cambiar el valor de 'iva'por ser una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}

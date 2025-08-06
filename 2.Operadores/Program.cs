namespace _2.Operadores
{

    internal class Program
    {


        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores numéricos
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine(num1 + "//" + num2 + "//" + num3 + "//" + num4);

            //Aritméticas
            int num5 = 3 + 5;//Suma
            Console.WriteLine(num5);
            int num6 = 100 - 26;//Resta
            Console.WriteLine(num6);
            int num7 = 4 * 2;//Producto
            Console.WriteLine(num7);
            float num8 = 5f / 3f;
            Console.WriteLine(num8);
            double num9 = 105d / 4;
            Console.WriteLine(num9);
            decimal num10 = 50m / 6;
            Console.WriteLine(num10);

            //Incremento decremento
            num10++;//num10 = num10 + 1;
            Console.WriteLine(num10);
            num1--;//num1=num1-1; Decremento
            Console.WriteLine(num1);

            //Console.ReadKey();

        }
    }


}



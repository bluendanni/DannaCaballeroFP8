using System;
using System.Timers;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

       

            Console.WriteLine("Ingrese el primer número");
               int numero1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
               int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
               int numero3 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 != numero2) && (numero2 != numero3) && (numero3 != numero1))
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine($"El número mayor es {numero1}");
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {numero3}");
                    }
                }
                else
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine($"El número mayor es {numero2}");
                    }
                    else {
                        Console.WriteLine($"El número mayor es {numero3}");
                    }
                }
                if ((numero1 > numero2))
                {
                    if ((numero1 > numero3))
                    {
                        if ((numero2 > numero3))
                        {
                            Console.WriteLine($"El orden es {numero1}, {numero2}, {numero3}");
                        }
                        else
                        {
                            Console.WriteLine($"El orden es {numero1}, {numero3}, {numero2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El orden es {numero3}, {numero1}, {numero2}");
                    }
                }
                else if ((numero2 > numero3))
                {
                    if ((numero3 > numero1))
                    {
                        Console.WriteLine($"El orden es {numero2}, {numero3}, {numero1}");
                    }
                    else
                    {
                        Console.WriteLine($"El orden es {numero2}, {numero1}, {numero3}");
                    }
                }
                else
                {
                    Console.WriteLine($"El orden es {numero3}, {numero2}, {numero1}");
                }
            }
            else
            {
                Console.WriteLine("Ingrese números diferentes entre si");
            }               
                    
         

            }
            
           


         





        }
    }

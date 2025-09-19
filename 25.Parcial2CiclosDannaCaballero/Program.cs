namespace _25.Parcial2CiclosDannaCaballero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular la nota definitiva de cada uno de los 25 estudiantes del curso de Ética,con el fin de identificar si aprobaron o reprobaron la asignatura.*/

            int numeroEstudiantes = 25;

            for (int i = 1; i <= numeroEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese la calificación del examen 1 del estudiante {i}:");
                double examen1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ingrese la calificación del examen 2 del estudiante {i}:");
                double examen2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ingrese la calificación del trabajo de investigación del estudiante {i}:");
                double trabajoInvestigacion = Convert.ToDouble(Console.ReadLine());

                double promedio = (examen1 + examen2 + trabajoInvestigacion) / 3;

                if (promedio >= 3.5)
                {Console.WriteLine($"El estudiante {i} APROBÓ con un promedio de {promedio:F1}."); }
                else
                { Console.WriteLine($"El estudiante {i} REPROBÓ con un promedio de {promedio:F1}."); }
                if (promedio > 5)
                { Console.WriteLine("Error: La calificación no puede ser mayor a 5. Ingrese las calificaciones nuevamente."); }
            }
        }
    }
}

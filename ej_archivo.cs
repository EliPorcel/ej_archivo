using System;
using System.IO;
namespace archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] datos = new string [5];
            for (int i = 0; i < 5; i++)
            {
                datos [i] = "Línea " + (i+1);
            }

            File.WriteAllLines ("ejemplo.txt", datos);
            String [] datos2 = File.ReadAllLines ("ejemplo.txt");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(datos2[i]);
            }
        
            Console.WriteLine ("Presione una tecla para finalizar");
            Console.ReadKey();
        }    
    }
}
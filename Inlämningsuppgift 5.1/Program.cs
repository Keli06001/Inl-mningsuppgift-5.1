using System;

namespace Inlämningsuppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            Console.WriteLine("Skriv in 5 namn");
            for (int i = 0; i < 5; i++)
            {
                namn[i] = Console.ReadLine();
            }
            for(int i = 0;i < 5; i++) 
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}

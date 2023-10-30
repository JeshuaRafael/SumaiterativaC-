using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca un número:");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 0;

        while (i < num)
        {
            Console.WriteLine("Número actual: " + i);
            i++;
        }
    }
}
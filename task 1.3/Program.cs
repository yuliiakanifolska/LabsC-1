using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть числа:");
        string input = Console.ReadLine();

        
        string[] numString = input.Split(' ');

        
        int[] num = numString.Select(int.Parse).ToArray();


        int firstDodat = num.FirstOrDefault(c => c > 0);
        int lastVid = num.LastOrDefault(c => c < 0);

        Console.WriteLine("Перший додатній елемент: " + firstDodat);
        Console.WriteLine("Останній від'ємний елемент: " + lastVid);
        Console.ReadKey();
    }
}

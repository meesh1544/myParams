using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int[] numbers= { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), };
        Console.WriteLine("How many integers do you want?");
        int size = int.Parse(Console.ReadLine());
        string[] stringArr= new string[size];
        fillString(stringArr);
        printString(stringArr);
        Console.WriteLine($"Total of the numbers added to the array={Add(numbers)}");
        Console.WriteLine($"Total of the numbers multiplied to the array={Multiply(numbers)}");
    }

    private static void fillString(string[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter the numbers {i + 1}");
            arr[i] = Console.ReadLine();
        }
    }

    private static void printString(string[] arr
        )
    {
        Console.WriteLine("");
        Console.WriteLine("Here is the list of integers");
        foreach (string n in arr)
            Console.WriteLine(n);
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
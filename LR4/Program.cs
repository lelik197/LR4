using System;

class Program
{
    static void Main()
    {
        int size = 15; // Таблица для чисел от 1 до 15 (0x1 - 0xF)
        
        Console.WriteLine("Таблица сложения (HEX):");
        PrintAdditionTable(size);
        
        Console.WriteLine("\nТаблица умножения (HEX):");
        PrintMultiplicationTable(size);
    }

    static void PrintAdditionTable(int size)
    {
        Console.Write("   | ");
        for (int i = 1; i <= size; i++)
            Console.Write($"{i:X2} ");
        Console.WriteLine("\n---+---------------------------------");

        for (int i = 1; i <= size; i++)
        {
            Console.Write($"{i:X2} | ");
            for (int j = 1; j <= size; j++)
                Console.Write($"{(i + j):X2} ");
            Console.WriteLine();
        }
    }

    static void PrintMultiplicationTable(int size)
    {
        Console.Write("   | ");
        for (int i = 1; i <= size; i++)
            Console.Write($"{i:X2} ");
        Console.WriteLine("\n---+---------------------------------");

        for (int i = 1; i <= size; i++)
        {
            Console.Write($"{i:X2} | ");
            for (int j = 1; j <= size; j++)
                Console.Write($"{(i * j):X2} ");
            Console.WriteLine();
        }
    }
}
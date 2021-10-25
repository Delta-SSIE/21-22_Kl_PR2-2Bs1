using System;
using System.Collections.Generic;

namespace _02_OOP_04_Fronta
{
    class Program
    {
        static void Main(string[] args)
        {
            //nová fronta na čísla
            Queue<int> numbers = new Queue<int>();

            //délka
            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");

            numbers.Enqueue(13);

            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");
            numbers.Enqueue(17);

            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");
            int next;
            
            next = numbers.Dequeue();
            Console.WriteLine($"Na řadě je {next}.");
            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");

            numbers.Enqueue(19);
            numbers.Enqueue(23);
            numbers.Enqueue(29);
            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");

            next = numbers.Dequeue();
            Console.WriteLine($"Na řadě je {next}.");
            Console.WriteLine($"Ve frontě je {numbers.Count} položek : {string.Join(", ", numbers)}.");
        }
    }
}

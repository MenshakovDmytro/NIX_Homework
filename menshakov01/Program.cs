using System;

namespace menshakov01
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Dmytro";
            var surname = "Menshakov";
            var age = 20;
            var yearsToForty = 40 - age;
            Console.WriteLine($"Hello! My name is {surname} {name}. I have {yearsToForty} years left to the start of my new life.");
        }
    }
}
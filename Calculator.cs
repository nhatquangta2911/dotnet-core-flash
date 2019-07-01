using System;

namespace VeryFirstNamespace
{
    public class Calculator
    {
        public static void Add(params int[] numbers) {
            System.Console.WriteLine(numbers[0]);
        }
    }
}
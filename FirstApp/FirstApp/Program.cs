﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    var sum = 0;
    foreach (var num in numbers)
    {
        sum += num;
    }
    return (double) sum / numbers.Length;
}
int[] numbers= {1,2,3,4};
double average=GetAverage(numbers);
Console.WriteLine(average);
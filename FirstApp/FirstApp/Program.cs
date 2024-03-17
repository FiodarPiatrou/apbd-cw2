// See https://aka.ms/new-console-template for more information

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

static int GetMax(int[] numbers)
{
    var nMax = 0;
    foreach (var n in numbers)
    {
        if (nMax<n)
        {
            nMax = n;
        }
    }

    return nMax;
}
int[] numbers= {1,2,3,4};
double average=GetAverage(numbers);
Console.WriteLine(average);
Console.WriteLine(GetMax(numbers));

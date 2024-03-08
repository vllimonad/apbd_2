// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//eprogjeo
//modification 1
//modification 2
//modification 3
static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}


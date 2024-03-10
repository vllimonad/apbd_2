// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//eprogjeo
//modification 1
//modification 2
//modification 3
static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Length;
}

int[] numbers = {1,2,3,4,5};
double average = GetAverage((numbers));
Console.WriteLine(average);

//modification 4
//modification 5
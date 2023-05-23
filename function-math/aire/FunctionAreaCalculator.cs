using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

class FunctionAreaCalculator
{
    public static double A;
    public static double B;
    public static double N;
    public static double S;
    public static double E;

    //contenu principal du code
    static void Main()
    {
        int count = 1;
        while (averageIntervals(count) > E)
        {
            Console.WriteLine(count);
        }
        Console.WriteLine("beuf");
    }

    static double averageIntervals(int i)
    {
        return f(i) - f(i - 1);
    }

    static double f(double i)
    {
        return A + i + calculateD();
    }

    static double calculateD()
    {
        return B - A / N;
    }

    
}

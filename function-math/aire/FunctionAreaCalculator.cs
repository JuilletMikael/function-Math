using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class FunctionAreaCalculator
{
    public static double A = 0;
    public static double B = 4;
    public static double N = 100;
    public static double S;
    public static double E;

    //contenu principal du code
    static void Main()
    {
        double total = 0;
        for (int i = 0; i < N; i++)
        {
            total += f(i);
        }
    }

    static double f(double x)
    {
        return Math.Pow(x, 2) + 2;
    }

    static double averageIntervals(int i)
    {
        return calculateD() * f(i) - f(i - 1);
    }

    static double calculateD()
    {
        return B - A / N;
    }

    
}

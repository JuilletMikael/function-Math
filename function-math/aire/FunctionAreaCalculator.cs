using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class FunctionAreaCalculator
{
    public static double A = 0;
    public static double B = 0;
    public static double N = 0;

    static void Main()
    {
        askUser();

        double total = 0;
        for (int i = 0; i < N; i++)
        {
            total += averageIntervals(i);
        }

        Console.WriteLine("L'aire est de " + total);
    }

    static double f(double x)
    {
        return Math.Pow(-x, 2) + 36;
    }


    static double averageIntervals(int i)
    {
        double x = A + i * calculateD();
        return calculateD() * (f(x) + f(x + calculateD())) / 2;
    }

    static double calculateD()
    {
        return (B - A) / N;
    }

    static void askUser()
    {
        Console.WriteLine("-x^2 + 36 [-6 ;6]");

        Console.WriteLine("Quel est votre intervalle négatif ?");
        double.TryParse(Console.ReadLine(), out A);

        Console.WriteLine("Quel est votre intervalle positif ?");
        double.TryParse(Console.ReadLine(), out B);

        Console.WriteLine("Quel est N ?");
        double.TryParse(Console.ReadLine(), out N);
    }
}

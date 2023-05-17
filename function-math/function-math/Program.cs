// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

double userA  = 0;
double userB = 1.5;
double E  = 0.00000001;
string userFunction = null;

double A = 0;
double B = 1.5;

Console.WriteLine("Origin = [" + A + ";" + B +"]");
Console.WriteLine("Epsilon =" + E );


while (averageIntervals(A, B)> E)
{
    if (f(averageIntervals(A, B)) >= 0)
    {
        B = averageIntervals(A, B);
        Console.WriteLine("[" + A + ";" + B + "]");
    }
    else
    {
        A = averageIntervals(A, B);
        Console.WriteLine("[" + A + ";" + B + "]");
    }
}



static double averageIntervals(double a, double b)
{
   return (a + b) / 2;
}


static double f(double x)
{
   return (double)(Math.Pow(x, 4) * (Math.Pow(x, 3) - 4) -1 * (Math.Pow(x, 3) - 4));
}

static void placementIntervals(double a, double b)
{
    if ((double)a < (double)b)
    {
        A = a;
        B = b;
    }
    else
    {
        A = b;
        B = a;  
    }
}

static void askUser()
{
    Console.WriteLine("Quel est votre fonction ?");
    //userFunction = Console.ReadLine();

    Console.WriteLine("Quel est votre intervale négative ?");
    string a = Console.ReadLine();
    Console.WriteLine(a);

    Console.WriteLine("Quel est votre intervale positive ?");
    string b = Console.ReadLine();

    Console.WriteLine("Quel est l'Epsilon ?");
    string E = Console.ReadLine();
}
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

class FindZero
{
    public static double userA = 0;
    public static double userB = 0;
    public static double E = 0;

    public static double A = 0;
    public static double B = 0;

    //contenu principal du code
    static void Main()
    {
        askUser();
        placementIntervals(userA, userB);

        Console.WriteLine("Origin = [" + A + ";" + B + "]");
        Console.WriteLine("Epsilon =" + E);

        while (averageIntervals(A, B) > E)
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
    }

    //calcul la moyenne de l'intervale 
    static double averageIntervals(double a, double b)
    {
        return (a + b) / 2;
    }

    //calcul la fonction f(x) = x^4 * (x^3 -4) -1 *(x^3 -4)
    //J'ai choisis celle ci car je trouvais cela complexe de transformer une unxion donné par l'utilisateur en format texte en fonction en code. 
    static double f(double x)
    {
        return (double)Math.Exp(-x) - x;
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
        Console.WriteLine("La fonction est f(x) = x^4 * (x^3 -4) -1 *(x^3 -4)");

        Console.WriteLine("Quel est votre intervalle négatif ?");
        double.TryParse(Console.ReadLine(),out userA);

        Console.WriteLine("Quel est votre intervalle positif ?");
        double.TryParse(Console.ReadLine(), out userB);

        Console.WriteLine("Quel est l'Epsilon ?");
        double.TryParse(Console.ReadLine(), out E);
    }
}

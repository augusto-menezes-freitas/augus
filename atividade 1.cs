using System;
class Program
{
    static void Main(string[] args)
    {
        double l;
        Console.WriteLine("Digite o valor do lado ");
        l = double.Parse(Console.ReadLine());
        double p = 4 * l;
        double a = l * l;
        double d = l * Math.Sqrt(2);
        Console.WriteLine("perimetro é " + p);
        Console.WriteLine("área é " + a);
        Console.WriteLine("diagonal é " + d);
        Console.ReadLine();
     }
}


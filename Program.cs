using System;
using Unit_Testing;

public class Program
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int  a, int b)
    {
        return a - b;
    }
    public static void Main(string[] args)
    {
        //Program p = new Program();

        //p.Addition(1, 2);
        //p.Subtraction(1, 2);

        //int sum = p.Addition(1, 2);
        //Console.WriteLine(sum);

        //int sub = p.Subtraction(1, 2);
        //Console.WriteLine(sub);
        PrimeNum.CheckPrime();
    }
}
using System;

public class Program
{
    public static void Main()
    {
        double numb01;
        double numb02;
        double numb03;
        int num = 3;
        Console.Write("Input a number!: ");
        numb01 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input a second number!: ");
        numb02 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input a third number!: ");
        numb03 = Convert.ToDouble(Console.ReadLine());
        double result = (numb01 + numb02 + numb03) / num ;
        Console.Write("= " + result);
    }
}
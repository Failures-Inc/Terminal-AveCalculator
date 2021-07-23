using System;

public class Program
{
    public static void Main()
    {

        // actual fucking code

        Look();
        Console.WriteLine("Hello! Welcome to the Average Calculator! \n \n Let's get Started!! \n");



       Cal();
        
        
    } public static void Cal(){

        // calculator method
        
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
        Console.Write($"The Average of {numb01}, {numb02} and {numb03} is {result}! \n \n");

        Console.WriteLine(" Do you want to restart?");
        // would you like to restart if statment
        string sen = (Console.ReadLine());
        if (sen == "yes"&&"Yes"){
            Console.WriteLine("--------------------------");
        
            Cal();

        }else if (sen == "no"){
            Environment.Exit(0);
             
        

        }
        

    } public static void Look(){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Title = "Average Calculator!";
        
        



    }
}
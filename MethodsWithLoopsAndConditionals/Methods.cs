using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodsWithLoopsAndConditionals;

internal class Methods
{
    public static void PrintNumbers1000()
    {
        for (int i = 1000; i >= -1000; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void PrintNumbers999()
    {
        for (int i = 3; i <= 999; i+=3)
        {
            Console.WriteLine(i);
        }
    }

    public static void AreEqualorNot(int x, int y)
    {
        if (x==y)
        {
            Console.WriteLine("These two numbers are equal.");
        }
        else
        {
            Console.WriteLine("These two numbers are not equal.");
        }
    }

    public static void EvenorOdd(int x)
    {
        if (x % 2 ==0)
        {
            Console.WriteLine("This number is even!");
        }
        else
        {
            Console.WriteLine("This number is odd!");
        }
    }
    public static void PositiveorNegative(int x)
    {
        if (x > 0)
        {
            Console.WriteLine("This number is positive");
        }
        else if (x == 0)
        {
            Console.WriteLine("This number is 0");
        }
        else
        {
            Console.WriteLine("This number is negative");
        }
    }

    public static void CanVote()
    {
        Console.Write("Please enter your age: ");
        _ = int.TryParse(Console.ReadLine(), out int age);

        if(age >= 18)
        {
            Console.WriteLine("You are old enough to vote!");
        }
        else
        {
            Console.WriteLine("Sorry! You're not quite old enough yet, maybe next year!");
        }


    }

    public static void IsInRange()
    {
        Console.WriteLine("Please enter a number and I'll see if it's in range: ");
        var couldparse = int.TryParse(Console.ReadLine(), out int number);
        if (number <= 10 && number >= -10)
        {
            Console.WriteLine("This number is in the range of 10 -> -10");
        }
        else
        {
            Console.WriteLine("This number is NOT in the range of 10 -> -10");
        }
    }
    public static void MultiplicationTable(int number)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} * {number} = {i * number}");
        }
    }

}

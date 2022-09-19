using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals;
internal class Methods
{
    public static void Print1000()
    {
        for (int i = -1000; i <= 1000; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Print999()
    {
        for (int i = 3; i <= 999; i+=3)
        {
            Console.WriteLine(i);
        }
    }

    public static void IsEqualOrNot(int num1, int num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine("These 2 numbers ARE equal");
        }
        else
        {
            Console.WriteLine("These 2 numbers ARE NOT equal");
        }
    }

    public static void IsEvenOrOdd(int number) 
    {
        if (number % 2 == 0) 
        {
            Console.WriteLine("This an EVEN number");
        }
        else
        {
            Console.WriteLine("This is an ODD number");
        }
    }

    public static void IsPositiveOrNegative(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("This number is POSITIVE");
        }
        else if (number < 0)
        {
            Console.WriteLine("This number is NEGATIVE");
        }
        else
        {
            Console.WriteLine("This number is 0");
        }
    }

    public static void CanVote()
    {
        Console.Write("Please enter your age: ");
        bool couldParseAge = int.TryParse(Console.ReadLine(), out int age);
        if (age >= 18)
        {
            Console.WriteLine("You CAN vote!");
        }
        else
        {
            Console.WriteLine("You can NOT vote!");
        }
    }

    public static void IsInRange()
    {
        Console.WriteLine("Please enter a number and I'll check if it's in the range!");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > -10 && number < 10)
        {
            Console.WriteLine("The number IS in the range!");
        }
        else
        {
            Console.WriteLine("The number IS NOT in the range!");
        }
    }

    public static void MultiplicationTable(int number)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}

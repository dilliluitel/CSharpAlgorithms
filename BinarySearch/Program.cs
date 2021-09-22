using System;
using static System.Console;

/// <summary>
/// Here we search an entire sorted array.
/// </summary>
public class Program
{
    public static void Main()
    {
        string[] dinners = {"Pasta",
                              "Apple Pie",
                              "Tuna Melt",
                              "Mushroom Omelet",
                              "Duck",
                              "Eggplant"};

        WriteLine();
        WriteLine("Content of array:");
        WriteLine("------------------");
        foreach (string dinner in dinners)
        {
            WriteLine(dinner);
        }

        WriteLine("\nContent after Sort:");
        WriteLine("------------------");
        Array.Sort(dinners);

        foreach (string dinner in dinners)
        {
            WriteLine(dinner);
        }

        WriteLine("\nBinarySearch for 'Beet Salad':");
        int index = Array.BinarySearch(dinners, "No");
        //Console.WriteLine(index);   //printing to see the negative index values
        DislpayWhere(dinners, index);

        WriteLine("\nBinarySearch for 'Tuna Melt':");
        index = Array.BinarySearch(dinners, "Tuna Melt");
        DislpayWhere(dinners, index);
    }

    private static void DislpayWhere<T>(T[] array, int index)
    {
        if (index < 0)
        {
            //Console.WriteLine(index);  //test prints
            index = ~index;    //negates the negative signed bits
            //Console.WriteLine(index);

            Write("Not found. Sorts between: ");

            if (index == 0)
                Write("beginning of array and ");
            else
                Write("{0} and ", array[index - 1]);

            if (index == array.Length)
                WriteLine("end of array.");
            else
                WriteLine("{0}.", array[index]);
        }
        else
        {
            WriteLine("Found at index {0}.", index);
        }
    }
}
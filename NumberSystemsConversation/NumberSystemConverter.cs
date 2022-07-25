using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BidirectionalDict;

namespace NumberSystemsConversation;

public static class NumberSystemConverter
{
    static NumberSystemConverter()
    {
        Numbers.TryAdd('0', 0);
        Numbers.TryAdd('1', 1);
        Numbers.TryAdd('2', 2);
        Numbers.TryAdd('3', 3);
        Numbers.TryAdd('4', 4);
        Numbers.TryAdd('5', 5);
        Numbers.TryAdd('6', 6);
        Numbers.TryAdd('7', 7);
        Numbers.TryAdd('8', 8);
        Numbers.TryAdd('9', 9);
        Numbers.TryAdd('A', 10);
        Numbers.TryAdd('B', 11);
        Numbers.TryAdd('C', 12);
        Numbers.TryAdd('D', 13);
        Numbers.TryAdd('E', 14);
        Numbers.TryAdd('F', 15);
    }

    internal static readonly BiDictionary<char, int> Numbers = new();

    public static int ConvertToDecimal(int actualSystem, string number)
    {
        if (number == null)
            throw new ArgumentNullException("Number argument cannot be null");

        var decimalNumber = 0;
        Console.WriteLine($"Converting {number} of {actualSystem} system to decimal system");


        for (var i = 0; i < number.Length; i++)
        {
            var tempDecimalNumber = decimalNumber;
            double currentDegree = number.Length - i - 1;
            decimalNumber += Numbers[number[i]] * (int)Math.Pow(actualSystem, currentDegree);
            Console.WriteLine
                ($"Step {i + 1}: {tempDecimalNumber} + {Numbers[number[i]]} * {actualSystem}^{currentDegree} = {decimalNumber}");
        }

        Console.WriteLine($"{decimalNumber} is number converted to decimal system");
        return decimalNumber;
    }

    public static string ConvertDecimalToCustom(int newSystem, int decimalNumber)
    {
        Console.WriteLine($"Convert {decimalNumber} from decimal to {newSystem} system");
        var result = "";

        while (decimalNumber != 0)
        {
            var resultForThisDegree = decimalNumber % newSystem;
            Console.WriteLine($"{decimalNumber}%{newSystem} = {resultForThisDegree}");
            Console.WriteLine(
                $"'{Numbers[resultForThisDegree]}' + '{result}' = {Numbers[resultForThisDegree] + result}");
            result = Numbers[resultForThisDegree] + result;

            decimalNumber /= newSystem;
        }

        return result;
    }
}
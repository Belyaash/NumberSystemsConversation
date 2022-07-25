namespace NumberSystemsConversation;

using ConsoleInput;

public static class Program
{
    public static void Main()
    {
        var startSystem = Input.CreateNumber<int>("Enter system of your number", MinMax<int>.Range(2, 16));
        var rule = new List<ICheckRule>()
        {
            CheckRule.GetCheckRulesBySystem(startSystem)
        };
        var number = Input.InputHexadecimalString("Enter your number", MinMax<uint>.TypeRange(), rule);
        var finalSystem = Input.CreateNumber<int>("Enter system to convert", MinMax<int>.Range(2, 16));
        string finalNumber;

        Console.WriteLine("//------------------------\\\\");
        var decimalNumber = NumberSystemConverter.ConvertToDecimal(startSystem, number);

        if (finalSystem == 10)
        {
            finalNumber = decimalNumber.ToString();
        }
        else
        {
            Console.WriteLine("//------------------------\\\\");
            finalNumber = NumberSystemConverter.ConvertDecimalToCustom(finalSystem, decimalNumber);
        }

        Console.WriteLine($"Final result is {finalNumber}");
    }
}
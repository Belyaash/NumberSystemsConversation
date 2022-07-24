namespace NumberSystemsConversation;
using ConsoleInput;

public static class Program
{
    public static void Main()
    {
        int startSystem = Input.CreateNumber<int>("Enter system of your number", MinMax<int>.Range(2, 16));
        List<ICheckRule> rule = new List<ICheckRule>()
        {
            CheckRule.GetCheckRulesBySystem(startSystem)
        };
        string number = Input.InputHexadecimalString("Enter your number", MinMax<uint>.TypeRange(),rule);
        int finalSystem = Input.CreateNumber<int>("Enter system to convert", MinMax<int>.Range(2, 16));

        int decimalNumber = NumberSystemConverter.ConvertToDecimal(startSystem, number);
        Console.WriteLine();
        string finalNumber = NumberSystemConverter.ConvertDecimalToCustom(finalSystem, decimalNumber);

        Console.WriteLine($"Final result is {finalNumber}");
    }


}
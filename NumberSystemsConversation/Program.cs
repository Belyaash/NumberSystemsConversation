namespace NumberSystemsConversation;

public static class Program
{
    public static void Main()
    {
        var a = NumberSystemConverter.ConvertDecimalToCustom(4, 101);
        Console.WriteLine(a);
    }
}
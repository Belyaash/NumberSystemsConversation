using static NumberSystemsConversation.NumberSystemConverter;

namespace NumberSystemsConversation.Tests;

public class NumberSystemConverterTests
{
    [Fact]
    public void ConvertBinaryToDecimal()
    {
        var decimalNum = ConvertToDecimal(2, "101");
        Assert.Equal(5, decimalNum);
    }

    [Fact]
    public void ConvertDecimalToDecimal()
    {
        var decimalNum = ConvertToDecimal(10, "101");
        Assert.Equal(101, decimalNum);
    }

    [Fact]
    public void ConvertHexadecimalToDecimal()
    {
        var decimalNum = ConvertToDecimal(2, "A");
        Assert.Equal(10, decimalNum);
    }


    [Fact]
    public void ConvertDecimalToBinary()
    {
        string CustomNum = ConvertDecimalToCustom(2, 5);
        Assert.Equal("101", CustomNum);
    }

    [Fact]
    public void ConvertDecimalToDecimal2()
    {
        string CustomNum = ConvertDecimalToCustom(10, 101);
        Assert.Equal("101", CustomNum);
    }

    [Fact]
    public void ConvertDecimalToDecimal3()
    {
        string CustomNum = ConvertDecimalToCustom(10, 1000);
        Assert.Equal("1000", CustomNum);
    }

    [Fact]
    public void ConvertDecimalToHexadecimal()
    {
        string CustomNum = ConvertDecimalToCustom(16, 10);
        Assert.Equal("A", CustomNum);
    }
}
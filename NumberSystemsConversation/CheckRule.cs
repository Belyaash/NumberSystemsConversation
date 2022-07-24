using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleInput;

namespace NumberSystemsConversation;
internal class CheckRule : ICheckRule
{
    private readonly List<char> _validChars;

    private CheckRule(List<char> validChars)
    {
        _validChars = validChars;
    }

    internal static CheckRule GetCheckRulesBySystem(int system)
    {
        var validChars = new List<char>();
        for (int i = 0; i < system; i++)
        {
            validChars.Add(NumberSystemConverter.Numbers[i]);
        }

        return new CheckRule(validChars);
    }

    public bool Validate(string result, char symbol)
    {
        return _validChars.Contains(symbol.ToString().ToUpper()[0]);
    }
}

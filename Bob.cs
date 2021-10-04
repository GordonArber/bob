using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        var trimmedStatement = statement.Trim();
        var question = trimmedStatement.EndsWith("?");
        var yelling = trimmedStatement.ToUpper();
        var hasLetters = trimmedStatement.Any(char.IsLetter);

        if (trimmedStatement == "")
        {
            return "Fine. Be that way!";
        }
        else if (statement == yelling && question && hasLetters)
        {
            return "Calm down, I know what I'm doing!";
        }else if (statement == yelling && !question && hasLetters)
        {
            return "Whoa, chill out!";
        } else if (question )
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
    }
}
namespace AzuBasic.Types;

public enum TokenType
{
    Number, String, Identifier, Keyword, Operator, EOF, EOL
}

public class Token
{
    public TokenType Type;
    public string Value;
    
    public Token(TokenType type, string value)
    {
        this.Type = type;
        this.Value = value;
    }
    
    public override string ToString()
    {
        return $"Token({Type}, {Value})";
    }


    public static List<string> Keywords =
    [
        "PRINT"
    ];
}
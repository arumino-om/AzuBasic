using AzuBasic.Types;

namespace AzuBasic;

public class Lexer
{
    private string code;
    private int i;
    
    public Lexer(string code)
    {
        this.code = code;
        this.i = 0;
    }
    
    public Token GetNextToken()
    {
        switch (code[i])
        {
            case '\n':
                return new Token(TokenType.EOL, null);
            
            case '"':
                // Text
                i++;
                var text = "";
                while (code[i] == '"' && code[i - 1] != '\\')
                {
                    text += code[i];
                    i++;
                }

                return new Token(TokenType.String, text);
            
            default:
                // A~Zの場合（キーワード，または変数）
                if (code[i] >= 'A' && code[i] <= 'Z')
                {
                    var statement = "";
                    while (code[i] >= 'A' && code[i] <= 'Z')
                    {
                        statement += code[i];
                        i++;
                    }
                    
                    // キーワード辞書にあるかどうか
                    if (Token.Keywords.Contains(statement))
                    {
                        return new Token(TokenType.Keyword, statement);
                    }
                    // なければ変数
                    return new Token(TokenType.Identifier, statement);
                }

                // 0~9の場合（数値）
                if (code[i] >= '0' && code[i] <= '9')
                {
                    var number = "";
                    while (code[i] >= '0' && code[i] <= '9' || code[i] == '.')
                    {
                        number += code[i];
                        i++;
                    }

                    return new Token(TokenType.Number, number);
                }
                
                break;
        }

        //NOTE: 例外飛ばしたほうがいいかも？
        return new Token(TokenType.EOL, null);
    }
}
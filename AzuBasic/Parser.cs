using AzuBasic.Types;
using AzuBasic.Types.Nodes;

namespace AzuBasic;

public class Parser
{
    private Lexer lexer;
    private Token currentToken;

    public Parser(Lexer lexer)
    {
        this.lexer = lexer;
        this.currentToken = lexer.GetNextToken();
    }
    
    public ASTNode Parse()
    {
        //TODO: 文法規則に従って解析を行い、ASTを構築
        return null;
    }
}
namespace AzuBasic.Types.Nodes;

public class BinaryOperationNode : ASTNode
{
    public ASTNode Left { get; set; }
    public string Operator { get; set; }
    public ASTNode Right { get; set; }

    public int Precedence
    {
        get
        {
            switch (Operator)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
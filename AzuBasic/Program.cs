namespace AzuBasic;

class Program
{
    public const int VERSION_MAJOR = 0;
    public const int VERSION_MINOR = 0;
    public const int VERSION_PATCH = 1;
    public const string PROGRAM_NAME = "AzuBasic";
    
    static void Main(string[] args)
    {
        Console.WriteLine($"{PROGRAM_NAME} v{VERSION_MAJOR}.{VERSION_MINOR}.{VERSION_PATCH}");
        
    }
}
namespace JsonParser;

class Program
{
    static void Main(string[] args)
    {
        Parser parserInvalid = new Parser(@"C:\Users\srish\Downloads\tests\step1\invalid.json");
        Console.Write("Invalid JSON Test: ");
        parserInvalid.IsValidJson();

        Console.WriteLine();

        Parser parserValid = new Parser(@"C:\Users\srish\Downloads\tests\step1\valid.json");
        Console.Write("Valid JSON Test: ");
        parserValid.IsValidJson();

        System.Console.WriteLine();

        Parser parserMultiLine = new Parser(@"C:\Users\srish\Downloads\tests\step1\validMultiline.json");
        Console.Write("Valid Multiline JSON Test: ");
        parserMultiLine.IsValidJson();
    }
}

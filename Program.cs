namespace JsonParser;

class Program
{
    static void Main(string[] args)
    {
        Parser parserInvalid = new Parser(@"C:\Users\srish\Downloads\tests\step1\invalid.json");

        Console.WriteLine("Invalid JSON Test: " + parserInvalid.IsValidJson());

        Parser parserValid = new Parser(@"C:\Users\srish\Downloads\tests\step1\valid.json");
        Console.WriteLine("Valid JSON Test: " + parserValid.IsValidJson());
    }
}

namespace JsonParser;

class Program
{
    static void Main(string[] args)
    {
        Parser parserInvalid = new Parser(@"C:\Users\srish\Downloads\tests\step2\invalid.json");
        Console.Write("Invalid JSON Test: ");
        parserInvalid.IsValidJson();

        Console.WriteLine();

        Parser parserInvalid2 = new Parser(@"C:\Users\srish\Downloads\tests\step2\invalid2.json");
        Console.Write("Invalid JSON Test 2: ");
        parserInvalid2.IsValidJson();

        Console.WriteLine();

        Parser valid = new Parser(@"C:\Users\srish\Downloads\tests\step2\valid.json");
        Console.Write("Valid Multiline JSON Test: ");
        valid.IsValidJson();

        Console.WriteLine();

        Parser valid2 = new Parser(@"C:\Users\srish\Downloads\tests\step2\student_record.json");
        Console.Write("Valid JSON Test 2: ");
        valid2.IsValidJson();
    }
}

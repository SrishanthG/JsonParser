namespace JsonParser
{
    public class Parser
    {
        private string _filePath;
        public string FilePath { get{return _filePath;} set{_filePath = value;} }

        private string[] _jsonLines;
        public string[] JsonLines { get{return _jsonLines;} set{_jsonLines = value;} }

        private string _objectContent;
        public string ObjectContent { get{return _objectContent;} set{_objectContent = value;} }

        public Parser(string filePath)
        {
            FilePath = filePath;
            JsonLines = File.ReadAllLines(filePath);
            ObjectContent = File.ReadAllText(filePath)[1..^1];
        }

        public bool HasGoodBrackets()
        {
            if (JsonLines.Length == 0)
            {
                return false;
            }
            else if (JsonLines.Length == 1)
            {
                return JsonLines[0].Trim().StartsWith("{") && JsonLines[0].Trim().EndsWith("}");
            }
            else
            {
                return JsonLines[0].Trim().StartsWith("{") && JsonLines[JsonLines.Length - 1].Trim().EndsWith("}");
            }
        }

        public bool HasGoodKeyValue()
        {
            if (ObjectContent.Trim().EndsWith(","))
            {
                Console.Write("Object has trailing comma.");
                return false;
            }

            string[] pairs = ObjectContent.Split(",");

            for (int i=0; i<pairs.Length; i++)
            {
                string[] pair = pairs[i].Trim().Split(":");

                if (pair.Length != 2)
                {
                    Console.Write($"Key-value pair {i + 1} does not have both a key and value.");
                    return false;
                }

                if (!pair[0].Trim().StartsWith("\"") || !pair[0].Trim().EndsWith("\""))
                {
                    Console.Write($"Key in key-value pair {i + 1} is not double-quoted.");
                    return false;
                }
            }

            return true;
        }

        public void IsValidJson()
        {
            if (!HasGoodBrackets())
            {
                Console.Write("Object does not open and close with curly braces.");
                return;
            }

            if (!HasGoodKeyValue())
            {
                Console.Write(" Object does not have proper key-value pairs.");
                return;
            }

            Console.Write("Valid JSON.");
        }
    }
}
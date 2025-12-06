namespace JsonParser
{
    public class Parser
    {
        private string _filePath;
        public string FilePath { get{return _filePath;} set{_filePath = value;} }

        private string[] _jsonLines;
        public string[] JsonLines { get{return _jsonLines;} set{_jsonLines = value;} }

        public Parser(string filePath)
        {
            FilePath = filePath;
            JsonLines = File.ReadAllLines(filePath);
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

        public bool IsValidJson()
        {
            if (!HasGoodBrackets())
            {
                return false;
            }
            else
            {
                // Placeholder for further JSON validation logic
                return true;
            }
        }
    }
}
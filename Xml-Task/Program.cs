class Program
{
    public static void Main(string[] args)
    {
        string fileName = "gentext.xml";
        string path = Path.GetFullPath(fileName);

        // if (!File.Exists(path))
        // {
        //     Console.WriteLine("File doesn't exist in this path");
        // }

        string id = "42014";

        // call xmlService to get value of target element
        var xmlService = new XmlService();
        var target = xmlService.GetTargetValue(path, id);

        if (string.IsNullOrEmpty(target))
        {
            Console.WriteLine("Target not found.");
        }

        // call fileService to write value in a file
        var fileService = new FileService();
        fileService.WriteFile(target);
    }
}

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

        // create new xmlService object 
        var xmlService = new XmlService();
        var target = xmlService.GetTargetValue(path, id);

        if (string.IsNullOrEmpty(target))
        {
            Console.WriteLine("Target not found.");
        }

        var fileService = new FileService();
        fileService.WriteFile(target);
    }
}

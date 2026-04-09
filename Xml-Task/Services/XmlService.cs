using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

public class XmlService {
    public string GetTargetValue(string filePath, string id)
    {
        // Load xml file 
        var doc = XDocument.Load(filePath);

        // Find id = 42014
        var element = doc.Descendants()
        .FirstOrDefault(e => (string)e.Attribute("id") == id);

        // if (element == null)
        // {
        //     Console.WriteLine($"Attribut {id} target not found");
        // }

        // Get target value
        var target = element?.Element("target")?.Value;

        Console.WriteLine(target);

        return target;
    }
}




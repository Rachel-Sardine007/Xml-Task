public class FileService()
{
    public void WriteFile(string targetValue)
    {
        File.WriteAllText("Output.txt", targetValue);
    }
}
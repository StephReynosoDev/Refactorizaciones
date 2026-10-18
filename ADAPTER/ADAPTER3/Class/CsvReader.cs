public class CsvReader
{
    public string GetCSV()
    {
        return File.ReadAllText("Csv/data.csv");
    }
}
public class CsvAdapter : IFileReader
{
    private CsvReader _csvReader;



    public CsvAdapter(CsvReader csvReader)
    {
        _csvReader = csvReader;
    }

    public string ReadData()

    {
        string csvData = _csvReader.GetCSV();

        //parea que tenga el formato parecido al de un json
         return $"{{ \"origen\": \"csv\", \"datos\": \"{csvData}\" }}";
    }
}
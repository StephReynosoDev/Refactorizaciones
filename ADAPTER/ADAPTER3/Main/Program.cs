class Program
{
    static void Main()
    {
        JsonReader jsonReader = new JsonReader();
        IFileReader fileReader = jsonReader;
        string dataJson = fileReader.ReadData();
        Console.WriteLine(dataJson);



        CsvReader csvReader = new CsvReader();
        IFileReader csvAdapter = new CsvAdapter(csvReader);
        string dataCsv = csvAdapter.ReadData();
        Console.WriteLine(dataCsv);
        
    }
    }

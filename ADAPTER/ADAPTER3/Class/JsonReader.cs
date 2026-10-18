public class JsonReader : IFileReader
{
    public string ReadData()


    {
      
        string texto = File.ReadAllText("Json/data.json");

        return texto;
    }
}
namespace MasaWebApp1.Class
{
    public interface IReadJson
    {
        public void ReadJson();
    }

    public interface IDeserializeJson
    {
        public DataSources DeserializeJson(string json);
    }

    public interface ISerializeJson
    {
        public string SerializeJson<T>(T obj);
    }
}

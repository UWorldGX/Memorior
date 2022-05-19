using Newtonsoft.Json;

namespace MasaWebApp1.Class
{
    public class Deserialize : IDeserializeJson
    {
        public DataSources DeserializeJson(string json)
        {
            DataSources DT = new();
            DT = JsonConvert.DeserializeObject<DataSources>(json);
            return DT;
        }
    }
}

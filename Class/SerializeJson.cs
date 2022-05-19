using Newtonsoft.Json;

namespace MasaWebApp1.Class
{
    public class Serializer : ISerializeJson
    {
        public string SerializeJson<T>(T obj)
        {
            string result = JsonConvert.SerializeObject(obj);
            return result;
        }


    }
}

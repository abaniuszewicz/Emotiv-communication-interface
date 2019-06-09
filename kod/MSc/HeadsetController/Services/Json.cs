using Newtonsoft.Json;

namespace HeadsetController.Services
{
    internal class Json
    {
        internal string Serialize(object obj) => JsonConvert.SerializeObject(obj);
        internal T Deserialize<T>(string str) => JsonConvert.DeserializeObject<T>(str);
    }
}

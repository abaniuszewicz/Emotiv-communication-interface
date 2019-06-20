using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace HeadsetController.Services
{
    internal class JsonParser
    {
        internal string Serialize(object obj) => JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore});
        internal T Deserialize<T>(string str) => JsonConvert.DeserializeObject<T>(str, new JsonSerializerSettings());
    }
}

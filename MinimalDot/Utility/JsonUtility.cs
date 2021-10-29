using Newtonsoft.Json;

namespace ConsoleApp1.Utility
{
    public class JsonUtility
    {
        public static T FromJson<T>(string s)
        {
            return JsonConvert.DeserializeObject<T>(s);
        }

        public static string ToJson(object o )
        {
            return JsonConvert.SerializeObject(o);
        }
        
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business
{
    public class SerializeExample
    {
        public string SerializeToJson(Person person)
        {
            var setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var json = JsonConvert.SerializeObject(person, setting);
            return json;
        }

        public Person DeserializeFromJson(string json)
        {
            var setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var deserialized = JsonConvert.DeserializeObject<Person>(json, setting);
            return deserialized;
        }

        public Stream SerializeToXml(Person person)
        {
            var serializer = new XmlSerializer(typeof(Person));

            var result = new MemoryStream();
            serializer.Serialize(result, person);
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }

        public Person DeserializeFromXml(Stream personStream)
        {
            var serializer = new XmlSerializer(typeof(Person));
            var deserialized = serializer.Deserialize(personStream);
            return deserialized as Person;
        }
    }
}

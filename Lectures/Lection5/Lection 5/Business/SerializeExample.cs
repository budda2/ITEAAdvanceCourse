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
            var json = JsonConvert.SerializeObject(person);
            return json;
        }

        public Person DeserializeFromJson(string json)
        {
            var deserialized = JsonConvert.DeserializeObject<Person>(json);
            return deserialized;
        }

        public Stream SerializeToXml(Person person)
        {
            var serializer = new XmlSerializer(typeof(Person));

            var result = new MemoryStream();
            serializer.Serialize(result, person);
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

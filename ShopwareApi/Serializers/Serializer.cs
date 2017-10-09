using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace ShopwareApi.Serializers
{
    public static class Serializer
    {
        public static string SerializeObjectXml<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string SerializeObjectJson<T>(this T toSerialize)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();

            using (StringWriter textWriter = new StringWriter())
            {
                jsonSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string SerializeObjectYaml<T>(this T toSerialize)
        {
            var yamlSerializer = new SerializerBuilder().Build();

            return yamlSerializer.Serialize(toSerialize);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Serialization
    {
        object SerializableObject = new object();

        public static void Serialize(object obj, string name)
        {
            var PropertiesForNonSerializeList = PrepareProrertyToSerialization(obj);

            if (PropertiesForNonSerializeList.Count() == obj.GetType().GetProperties().Count())
            {
                throw new NoAvailablePropertiesException();
            }

            //  string serializableObject = System.Text.Json.JsonSerializer.Serialize<object>(obj);
            string serializableObject = "{";

            foreach (var item in PropertiesForNonSerializeList)
            {
                serializableObject += $"\"{item.Name}\":\"{item.GetValue(obj)}\",\n";
            }
            serializableObject = serializableObject.Remove(serializableObject.Length - 2);

            serializableObject += "}";

            System.IO.File.WriteAllText(name, serializableObject);

        }

        public static List<PropertyInfo> PrepareProrertyToSerialization(object obj)
        {
            var objType = obj.GetType();
            var PropertiesList = objType.GetProperties();

            List<PropertyInfo> PropertiesWithoutIgnoreAttribute = new List<PropertyInfo>();

            foreach (PropertyInfo item in PropertiesList)
            {
                if (!item.CustomAttributes.Any(x => x.AttributeType.Name == "IgnoreAttribute"))
                {
                    PropertiesWithoutIgnoreAttribute.Add(item);
                }
            }

            return PropertiesWithoutIgnoreAttribute;
        }

    }
}

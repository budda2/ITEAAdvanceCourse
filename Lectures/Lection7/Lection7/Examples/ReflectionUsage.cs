using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class ReflectionUsage
    {
        public object Do(object o)
        {
            var oType = o.GetType();

            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                  | BindingFlags.Static;
            FieldInfo field = oType.GetField("_privateData", bindFlags);
            field.SetValue(o, "NOW NOT VERY PRIVATE");
            var privateData = field.GetValue(o);

            oType.GetCustomAttribute(typeof(MyPluginAttribute));

            var assempbly = System.Reflection.Assembly.Load("Some assembly string");
            var myTypesDerived = assempbly.GetTypes().Where(TypeIsMarkedWithMyPluginAttribute);
            foreach (var item in myTypesDerived)
            {
                var created = (Class1)Activator.CreateInstance(item, "SomeClassName");
            }

            return privateData;
        }

        private static bool TypeIsMarkedWithMyPluginAttribute(Type t)
        {
           return !t.IsAbstract && t.GetCustomAttributes(false).FirstOrDefault(attr => attr.GetType().Equals(typeof(MyPluginAttribute))) != null && t.IsSubclassOf(typeof(Class1));
        }
    }
}

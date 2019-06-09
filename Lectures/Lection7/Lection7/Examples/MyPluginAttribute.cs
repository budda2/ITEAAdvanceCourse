using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class MyPluginAttribute : Attribute
    {
        private readonly string _something;

        public MyPluginAttribute(string something)
        {
            _something = something;
        }
    }
}

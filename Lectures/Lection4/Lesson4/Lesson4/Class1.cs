using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Class1
    {
        internal void SaveFile(Func<string, IFile> download, string path)
        {
            //do some param checks
            var file = download(path);
            //do something with file
        }

        public delegate void EventHandler(object sender, EventArgs args);
    }
}

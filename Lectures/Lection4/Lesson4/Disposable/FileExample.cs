using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class FileExample
    {
        private string _filePath = @"C:\GitHub\Itea\Advance\MHA\ITEAAdvanceCourse\Lectures\Lection4\txt.txt";
        public void WriteToFile(string message)
        {
            using (var file = File.OpenWrite(_filePath))
            using (var writer = new StreamWriter(file))
            {
                if (file.CanSeek)
                    file.Seek(0, SeekOrigin.End);

                writer.Write(message);
            }
        }

        public string ReadFromFile()
        {
            string result = null;
            using (var filestream = File.OpenRead(_filePath))
            using (var stream = new StreamReader(filestream))
            {
                result = stream.ReadToEnd();
            }
            return result;
        }
    }
}

using System.IO;

namespace Buisness
{
    public class FileWriter
    {
        private string _filePath = @"C:\GitHub\Itea\Advance\MHA\ITEAAdvanceCourse\Lectures\Lection5\person.txt";

        public void Write(string message)
        {
            using (var file = File.Open(_filePath, FileMode.OpenOrCreate))
            {
                if (file.CanSeek)
                    file.Seek(0, SeekOrigin.End);

                using (var writer = new StreamWriter(file))
                {
                    writer.WriteLine(message);
                }
            }
        }

        public void Wrote(Stream stream)
        {
            using (var file = File.Open(_filePath, FileMode.OpenOrCreate))
            {
                stream.CopyTo(file);
            }
        }
    }
}

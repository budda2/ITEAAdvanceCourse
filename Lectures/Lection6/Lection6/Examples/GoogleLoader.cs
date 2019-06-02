using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class GoogleLoader
    {
        public async Task<string> Load()
        {
            var client = new HttpClient();
            string result = null;
            using (client)
            {
                var response = await client.GetAsync(@"https://www.google.com");
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }

        public async Task DownloadAdvanceRepo()
        {
            var uri = @"https://github.com/budda2/ITEAAdvanceCourse/archive/master.zip";
            var client = new HttpClient();
            Stream result = null;
            using (client)
            {
                var response = await client.GetAsync(uri);
                result = await response.Content.ReadAsStreamAsync();
            }

            using (var file = File.Open(@"D:\repo.zip", FileMode.OpenOrCreate, FileAccess.Write))
            using (result)
            {
                if (result.CanSeek)
                    result.Seek(0, SeekOrigin.Begin);

                result.CopyTo(file);
            }

        }
    }
}

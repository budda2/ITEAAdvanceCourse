using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class ParallelExample
    {
        public void HandleStrings(IReadOnlyCollection<string> strings)
        {
            Parallel.ForEach(strings, s =>
            {
                var split = s.Split(',');
                //log all splitted parts
            });
        }

        public void AnotherHandleStrings(IReadOnlyCollection<string> strings)
        {
            Parallel.ForEach(strings, SingleStringHandler);
        }

        public void SingleStringHandler(string s)
        {
            var split = s.Split(',');
            //log all splitted parts
        }
    }
}

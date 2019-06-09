using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    [MyPlugin("Class something")]
    public class Examples
    {
        private string _privateData  = "VERY PRIVATE";
        public Examples(string className)
        {
        }

        public IEnumerable<int> Do(IEnumerable<string> strings)
        {
            //ordering
            var sorted = strings.OrderBy(s => s.Length);
            var same = sorted.Where(s => s.Length > 5).Take(10).Skip(5).Take(4);
            var result = same.FirstOrDefault();
            var special = strings.Where(s => s.Length < 10);


            var res1 =
                from s in strings
                where s.Length > 5
                select s;
            var res = strings.Select(s =>
            {
                var splited = s.Split(' ');
                var max = splited.Max(m => m.Length);
                var minWord = splited.Min(m => m.Length);
                return new { MaxWordLength = max, MinWordLength = minWord, Str = s };
            })
            .Where(t => t.MaxWordLength > 5)
            .Select(WorkWithAnonumus);

            return res;

        }

        private int WorkWithAnonumus(dynamic obj)
        {
            return (int)obj.MinWordLength + obj.MaxWordLength;
        }
    }
}

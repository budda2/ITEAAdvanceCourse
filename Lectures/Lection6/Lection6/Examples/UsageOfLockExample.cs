using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class UsageOfLockExample
    {
        public async Task<bool> UseLockExample()
        {
            var lockExample = new LockExample();

            var doTask = Task.Run(() => lockExample.Do());
            var doTask1 = Task.Run(() => lockExample.DoSomething());

            //if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            //{
            //    await Task.WhenAll(doTask, doTask1);
            //    await Task.WhenAny(doTask, doTask1);
            //    return false;
            //}
            return true;
        }
    }
}

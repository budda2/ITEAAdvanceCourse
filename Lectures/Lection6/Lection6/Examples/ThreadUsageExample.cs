using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    //Disclaimer: it is preffered to use Task.Run instead of creating new Thread. Why? Because creating new Thread object is very heavy operation requiring allocaion of 1 Mb of memory. To avoid this use thread ppol and high level API provided with Task class/
    class ThreadUsageExample
    {
        public void Example()
        {
            var thread = new Thread(() => OperationToBePerformedinBackground());
            thread.IsBackground = true;
            thread.Start();

            //call to wait for operation to finish (is optional, that is why commented out)
            //thread.Join();
        }

        private void OperationToBePerformedinBackground()
        {
            for (int i = 0; i < 2000; i++)
            {
                //makes thread to do nothing for n milliseconds.
                Thread.Sleep(1);
            }
        }
    }
}

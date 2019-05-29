using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    public class HardLongOperations
    {
        public void RunPerformanceHeavy()
        {
            for (int i = 0; i < 5000; i++)
            {
                //emulating that each loop iteration takes 1ms
                Thread.Sleep(1);
            }
        }

        public async Task RunPerformanceHeavyInBackground()
        {
            await Task.Run(() => RunPerformanceHeavy());
        }
    }
}

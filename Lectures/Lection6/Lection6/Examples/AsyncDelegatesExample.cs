using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class AsyncDelegatesExample
    {
        public async Task DoAsync()
        {            
            await Task.Run(async() =>
            {
                //simulate ongoing operation
                await Task.Delay(1000);
            });
        }
    }
}

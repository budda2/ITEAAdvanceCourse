using System;
using System.Collections.Generic;

namespace Delegates
{
    public class Counter
    {
        public event HandleHundredDelegate HundredReached;

        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 100)
                {
                    //to raise an event.
                    HundredReached?.Invoke();
                    RaiseHundredreached();
                    i = 0;
                }
            }
        }

        // Explicitly calls all the handler of event.
        //In case of exception on handler execution, other handlers will be executed
        private void RaiseHundredreached()
        {
            if (HundredReached == null)
                return;

            var exceptions = new List<Exception>();
            foreach(HandleHundredDelegate handler in HundredReached.GetInvocationList())
            {
                try
                {
                    handler.Invoke();
                }
                catch(Exception e)
                {
                    exceptions.Add(e);
                }
            }
            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);            
        }
    }
}

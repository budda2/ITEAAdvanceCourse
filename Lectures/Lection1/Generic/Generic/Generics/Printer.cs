using System;

namespace Generic.Generics
{
    //non-generic class
    public class Printer : IPrinter
    {
        //we do not care
        public string Name => throw new NotImplementedException();

        //we do not care
        public Uri Uri => throw new NotImplementedException();

        //Implementation of generic method from non-generic interface
        public void Print<T>(T itemToPrint)
        {
            Console.WriteLine(itemToPrint.ToString());
        }
    }
}

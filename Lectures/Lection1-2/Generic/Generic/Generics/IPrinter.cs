using System;

namespace Generic.Generics
{
    //Non-generic interface
    internal interface IPrinter
    {
        string Name { get; }
        Uri Uri { get; }

        //Generic METHOD declaration in non-generic interface
        void Print<T>(T itemToPrint);
    }
}

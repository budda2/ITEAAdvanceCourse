using System;

namespace Delegates
{
    public class Student
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
        }

        public void GreetClassmate(Student classMate)
        {
            Console.WriteLine($"Hi, {classMate.Name}");
        }
    }
}

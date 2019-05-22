using Delegates;
using System;
using System.Reflection;

namespace Console
{
    class Program
    {
        private static Counter _counter;

        static void Main(string[] args)
        {
            _counter = new Counter();
            //event subscription
            _counter.HundredReached += HandleHundredreached;
            _counter.Count();

            var student = new Student("Mark");
            var otherStudent = new Student("John");
            var lecturer = new Lecturer("Isaak");

            //new delegate object creations
            var handleStudents = new HandleStudentDelegate(lecturer.RateStudent);
            handleStudents(student);

            HandleStudentDelegate lambdaHandleStudent = s => HandleStudent(s);

            handleStudents(student);
        }

        public static void HandleHundredreached()
        {
            System.Console.WriteLine("HundredReached");
            System.Console.WriteLine("Press 'Any' key to continue");
            System.Console.ReadLine();
            _counter.HundredReached -= HandleHundredreached;
        }

        static void HandleStudent(Student student)
        {
            System.Console.WriteLine(student.Name);
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine(student.Name);
        }
    }

}

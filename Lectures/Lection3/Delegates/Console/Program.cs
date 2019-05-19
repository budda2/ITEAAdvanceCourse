using Delegates;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Mark");
            var otherStudent = new Student("John");
            var lecturer = new Lecturer("Isaak");
            var handleStudents = new HandleStudentDelegate(lecturer.RateStudent);
            HandleStudentDelegate lambdaHandleStudent = (Student s) => System.Console.WriteLine(s.Name);
            HandleStudentDelegate anonymusMethodHandleStudent = delegate (Student s)
            {
                System.Console.WriteLine(s.Name);
            };
            handleStudents(student);
        }
    }
}

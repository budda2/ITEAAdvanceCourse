using Disposable;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new FileExample();
            example.WriteToFile("HelloWorld");
            var fileContent = example.ReadFromFile();
        }
    }
}

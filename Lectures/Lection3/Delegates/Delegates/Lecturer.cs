namespace Delegates
{
    public class Lecturer
    {
        public string Name { get; }

        public Lecturer(string name)
        {
            Name = name;
        }

        public void RateStudent (Student student)
        {
            //for now do nothing
        }
    }
}

using System;

namespace DataModel
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public double Salary { get; set; }
        public string Nickname { get; set; }
        public string OtherNickname { get; set; }
    }
}

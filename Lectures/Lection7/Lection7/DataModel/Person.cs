using System;

namespace DataModel
{
    public class Person
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        DateTime DateOfBirth { get; set; }
        int Age => DateTime.Now.Year - DateOfBirth.Year;
    }
}

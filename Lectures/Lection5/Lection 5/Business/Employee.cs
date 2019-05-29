using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Employee : IEquatable<Employee>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid Id { get; set; }
        public int InsuranceNumber { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return Equals(other);

            return false;
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   Name == other.Name &&
                   Surname == other.Surname &&
                   Id.Equals(other.Id) &&
                   InsuranceNumber == other.InsuranceNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = -1193904574;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + InsuranceNumber.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return EqualityComparer<Employee>.Default.Equals(employee1, employee2);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}

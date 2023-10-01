using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Common
{
    public class PersonBase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public void SayMyName() => Console.WriteLine($"{FirstName} {LastName}");
        public int Addition(int number1, int number2) => number1 * number2;
    }
}

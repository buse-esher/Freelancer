using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    public class Student : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int No { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }
    }
}

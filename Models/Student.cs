////tinfo200:[2020-03-12-zeiko21-dykstra1] - Holds the student class where students information is contained
////tinfo200:[2020-03-12-zeiko21-dykstra1] In the student link of the homepage, a list of the students full name and enrollment date is shown. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student

        {
            public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

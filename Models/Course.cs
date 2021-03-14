////tinfo200:[2020-03-12-zeiko21-dykstra1]- Holds the student class where the course information is contained
////tinfo200:[2020-03-12-zeiko21-dykstra1] is associted with enrollment as  it carries a one-to-many relationship
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    { 
           [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
    
    }
}

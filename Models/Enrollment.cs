////tinfo200:[2020-03-12-zeiko21-dykstra1] - Holds the student class where th enrollment information is contained
////tinfo200:[2020-03-12-zeiko21-dykstra1] A grade is not assigned and there holds an undefined value
////tinfo200:[2020-03-12-zeiko21-dykstra1] - Enrollement is associted with course as  it carries a one-to-many relationship
namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}
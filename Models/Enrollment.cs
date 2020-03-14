using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    [Table("Enrollment")]
    public class Enrollment
    {
        [Column("EnrollmentID")]
        public int EnrollmentID { get; set; }

        [Column("CourseID")]
        public int CourseID { get; set; }

        [Column("StudentID")]
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        [Column("Grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
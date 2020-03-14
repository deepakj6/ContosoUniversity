using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    [Table("OfficeAssignment")]
    public class OfficeAssignment
    {
        [Key]
        [Column("InstructorID")]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]

        [Column("Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    [Table("Courseassignment")]
    public class CourseAssignment
    {
        [Column("InstructorID")]
        public int InstructorID { get; set; }

        [Column("CourseID")]
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
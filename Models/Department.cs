using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{

    [Table("Department")]
    public class Department
    {

        [Column("DepartmentID")]
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Column("Name")]
        public string Name { get; set; }

        //[DataType(DataType.Currency)]
        [Column("Budget")]        
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("InstructorID")]
        public int? InstructorID { get; set; }

        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
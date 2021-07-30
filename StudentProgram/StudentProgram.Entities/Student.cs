using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentProgram.Entities
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(8)]
        public string studentNumber { get; set; }

        [StringLength(25)]
        public string firstName { get; set; }

        [StringLength(25)]
        public string lastName { get; set; }

        [StringLength(25)]
        public string facultyName { get; set; }

        [StringLength(25)]
        public string departmentName { get; set; }
    }
}

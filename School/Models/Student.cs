using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string StudentName { get; set; }

        public int StudentNumber { get; set; }
    }
}

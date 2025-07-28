using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstAspWithEF.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName" ,TypeName ="varchar(100)")]
        [Required]
        public string Name { get; set; }
        [Column("StudentGender" ,TypeName ="varchar(50)")]
        [Required]
        public string Gender { get; set; }
        [Required]
        public int? Age  { get; set; }
        [Required]
        public int? Standard { get; set; }

    }
}

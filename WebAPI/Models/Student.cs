using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int YearLevel { get; set; }

        [Required]
        public string Course { get; set; }

        public int OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organizations { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Subject { get; set; }

        public string Adviser { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
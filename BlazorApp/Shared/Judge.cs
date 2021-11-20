using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared
{
    public class Judge
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [MaxLength(100)]
        public string Company { get; set;}

        [MaxLength(100)]
        public string Role { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public string Bio { get; set; }

        public string Headshot { get; set; }

        public string Category { get; set; }

        public bool Chair { get; set; } = false;
    }
}

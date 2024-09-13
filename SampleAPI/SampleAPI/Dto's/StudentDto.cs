using System.ComponentModel.DataAnnotations;

namespace SampleAPI.Dto_s
{
    public class StudentDto
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]

        public required long PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public required string Class { get; set; }

    

    }
}

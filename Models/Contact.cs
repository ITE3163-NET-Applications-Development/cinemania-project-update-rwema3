using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class Contact
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(2000, ErrorMessage="Message should not exceed 200 characters")]
        public string Message { get; set; }
    }
}
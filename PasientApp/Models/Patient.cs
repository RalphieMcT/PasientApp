using System.ComponentModel.DataAnnotations;

namespace PasientApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="Fdato er påkrevd")]
        public DateTime? DateOfBirth { get; set; } = null;
        public List<string> Conditions { get; set; } = new List<string>();
    }
}

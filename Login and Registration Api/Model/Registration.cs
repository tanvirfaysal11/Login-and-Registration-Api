using System.ComponentModel.DataAnnotations;

namespace LoginRegistrationApi.Model
{
    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;

    }
}

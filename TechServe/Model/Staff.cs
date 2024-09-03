using System.ComponentModel.DataAnnotations;

namespace TechServe.Model
{
    public class Staff
    {
        public int id { get; set; }
        public int StaffUsername { get; set; }
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Password must be exactly 6 digits")]
        public int PasswordSimple { get; set; }  // Opsiyonel
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}

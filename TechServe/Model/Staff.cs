using System.ComponentModel.DataAnnotations;

namespace TechServe.Model
{
    public class Staff
    {
        public int id { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public int StaffUsername { get; set; }
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public int PasswordSimple { get; set; }  // Opsiyonel
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}

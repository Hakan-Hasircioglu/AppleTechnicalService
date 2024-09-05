using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechServe.Model
{
    public class LoggedInStaff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public event Action OnChange;
        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}

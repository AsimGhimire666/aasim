using System.ComponentModel;

namespace CRUDWithADONet.Models
{
    public class Employee
    {
        [key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("LastName")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
    }

}

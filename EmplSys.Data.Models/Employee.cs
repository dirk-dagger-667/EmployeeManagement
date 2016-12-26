namespace EmplSys.Data.Models
{
    using Infrastructure;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthFirstName)]
        [MinLength(ValidationConstants.MinLengthFirstName)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthSurName)]
        [MinLength(ValidationConstants.MinLengthSurName)]
        public string SurName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthLastName)]
        [MinLength(ValidationConstants.MinLengthLastName)]
        public string LastName { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(ValidationConstants.MaxLengthEmail)]
        [MinLength(ValidationConstants.MinLengthEmail)]
        public string Email { get; set; }
    }
}

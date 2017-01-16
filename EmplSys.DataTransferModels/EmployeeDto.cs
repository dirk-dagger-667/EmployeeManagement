namespace EmplSys.DataTransferModels
{
    using Data.Infrastructure;
    using System.ComponentModel.DataAnnotations;

    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthFirstName, ErrorMessage = ErrorMesseges.FirstNameTooLong)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthSurName, ErrorMessage = ErrorMesseges.SurNameTooLong)]
        public string SurName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthLastName, ErrorMessage = ErrorMesseges.LastNameTooLong)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmail, ErrorMessage = ErrorMesseges.EmailTooLong)]
        [DataType(DataType.EmailAddress, ErrorMessage = ErrorMesseges.EmailInvalidFormat)]
        public string Email { get; set; }
    }
}

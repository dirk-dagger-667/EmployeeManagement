namespace EmplSys.DataTransferModels
{
    using System.ComponentModel.DataAnnotations;

    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}

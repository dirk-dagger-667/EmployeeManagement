namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}

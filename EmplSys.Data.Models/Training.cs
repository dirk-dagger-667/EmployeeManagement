namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;
    using System.Collections.Generic;

    public class Training
    {
        private ICollection<Employee> employeesPassed;

        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthTrainingName)]
        public string Name { get; set; }

        [Required]
        public int PassingScore { get; set; }

        [NotMapped]
        public string Description { get; set; }

        public virtual ICollection<Employee> EmployeesPassed
        {
            get { return this.employeesPassed; }
            set { this.employeesPassed = value; }
        }
    }
}
